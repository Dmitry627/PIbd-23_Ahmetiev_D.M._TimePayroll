using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TimePayroll.Entities;
using TimePayroll.Repositories;
using TimePayroll.Services;

namespace TimePayroll.Forms
{
    // Форма создания начисления зарплаты
    public partial class FormPayroll : Form
    {
        // Хранит репозиторий для сохранения начисления
        private readonly IPayrollRepository _payrollRepository;

        // Выполняет расчет за выбранный месяц
        private readonly PayrollCalculator _calculator;

        // Хранит начисление, которое сейчас показано на форме
        private Payroll? _calculatedPayroll;

        // Создает форму и загружает список работников
        public FormPayroll(IPayrollRepository payrollRepository, IEmployeeRepository employeeRepository, PayrollCalculator calculator)
        {
            InitializeComponent();
            _payrollRepository = payrollRepository;
            _calculator = calculator;

            comboBoxEmployee.DisplayMember = nameof(Employee.FirstName);
            comboBoxEmployee.DataSource = employeeRepository.ReadEmployees().ToList();
            comboBoxEmployee.SelectedIndex = -1;
        }

        // Показывает имя и фамилию работника в списке
        private void comboBoxEmployee_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Employee employee) {
                e.Value = $"{employee.FirstName} {employee.SecondName}";
            }
        }

        // Пересчитывает начисление при смене работника или месяца
        private void CalculationInput_Changed(object sender, EventArgs e)
        {
            _calculatedPayroll = null;
            buttonSave.Enabled = false;
            textBoxTotalHours.Clear();
            textBoxBaseSalary.Clear();
            textBoxBonusAmount.Clear();
            textBoxTotalSalary.Clear();

            if (comboBoxEmployee.SelectedItem is not Employee employee) {
                labelCalculationStatus.Text = "Выберите работника";
                return;
            }

            try {
                var payroll = _calculator.Calculate(employee, dateTimePickerPeriodMonth.Value);
                textBoxTotalHours.Text = payroll.TotalHours.ToString("0.##");
                textBoxBaseSalary.Text = payroll.BaseSalary.ToString("N2");
                textBoxBonusAmount.Text = payroll.BonusAmount.ToString("N2");
                textBoxTotalSalary.Text = payroll.TotalSalary.ToString("N2");
                labelCalculationStatus.Text = string.Empty;
                _calculatedPayroll = payroll;
                buttonSave.Enabled = true;
            }
            catch (Exception ex) {
                labelCalculationStatus.Text = ex.Message;
            }
        }

        // Передает рассчитанное начисление в репозиторий
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_calculatedPayroll is null) {
                return;
            }

            try {
                _payrollRepository.CreatePayroll(_calculatedPayroll);
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    this, ex.Message, "Ошибка при сохранении начисления",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Закрывает форму без сохранения
        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}
