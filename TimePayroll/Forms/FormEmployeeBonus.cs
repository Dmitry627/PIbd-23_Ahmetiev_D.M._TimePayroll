using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TimePayroll.Entities;
using TimePayroll.Entities.Enums;
using TimePayroll.Repositories;

namespace TimePayroll.Forms
{
    // Форма назначения надбавки работнику
    public partial class FormEmployeeBonus : Form
    {
        // Хранит репозиторий надбавок работников
        private readonly IEmployeeBonusRepository _employeeBonusRepository;

        // Создает форму и заполняет списки работников и надбавок
        public FormEmployeeBonus(IEmployeeBonusRepository employeeBonusRepository, IEmployeeRepository employeeRepository)
        {
            InitializeComponent();
            _employeeBonusRepository = employeeBonusRepository ?? throw new ArgumentNullException(nameof(employeeBonusRepository));
            ArgumentNullException.ThrowIfNull(employeeRepository);

            comboBoxEmployee.DisplayMember = "FullName";
            comboBoxEmployee.ValueMember = nameof(Employee.Id);
            comboBoxEmployee.DataSource = employeeRepository.ReadEmployees()
                .Select(employee => new
                {
                    employee.Id,
                    FullName = $"{employee.FirstName} {employee.SecondName}"
                })
                .ToList();
            comboBoxEmployee.SelectedIndex = -1;

            foreach (var type in Enum.GetValues<BonusType>()) {
                if (type is not BonusType.None) {
                    var title = type switch 
                    {
                        BonusType.Experience => "За стаж",
                        BonusType.Qualification => "За квалификацию",
                        BonusType.Performance => "За результативность",
                        BonusType.ProjectComplexity => "За сложность проекта",
                        _ => type.ToString()
                    };

                    checkedListBoxBonusTypes.Items.Add(new BonusTypeOption(type, title));
                }
            }
        }

        // Проверяет ввод и передает назначение надбавок в репозиторий
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try {
                if (comboBoxEmployee.SelectedValue is not long employeeId) throw new InvalidDataException("Выберите работника");

                var bonusTypes = BonusType.None;
                foreach (BonusTypeOption option in checkedListBoxBonusTypes.CheckedItems) {
                    bonusTypes |= option.Type;
                }

                if (bonusTypes is BonusType.None) throw new InvalidDataException("Отметьте хотя бы один вид надбавки");

                var startDate = dateTimePickerStartDate.Value.Date;
                var endDate = dateTimePickerEndDate.Value.Date;
                if (endDate < startDate) throw new InvalidDataException("Дата окончания не может быть раньше даты начала");

                var bonus = EmployeeBonus.CreateEntity(0, employeeId, (int)bonusTypes, startDate, endDate);
                _employeeBonusRepository.CreateEmployeeBonus(bonus);
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "Ошибка при сохранении надбавки",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Закрывает форму без сохранения
        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        // Связывает значение перечисления с подписью в списке
        private sealed record BonusTypeOption(BonusType Type, string Title)
        {
            // Возвращает подпись для отображения в списке
            public override string ToString() => Title;
        }
    }
}
