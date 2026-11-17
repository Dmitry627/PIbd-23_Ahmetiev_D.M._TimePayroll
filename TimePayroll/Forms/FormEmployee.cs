using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TimePayroll.Repositories;
using TimePayroll.Entities;

namespace TimePayroll.Forms
{
    public partial class FormEmployee : Form
    {
        private readonly IEmployeeRepository _employeeRepository;

        private readonly IPositionRepository _positionRepository;

        private long? _employeeId;

        public long Id
        {
            set
            {
                try
                {
                    var employee = _employeeRepository.ReadEmployeeById(value);
                    if (employee is null) throw new InvalidDataException("Работник не найден");
                    textBoxFirstName.Text = employee.FirstName;
                    textBoxSecondName.Text = employee.SecondName;
                    comboBoxPosition.SelectedValue = employee.PositionId;
                    _employeeId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Ошибка при получении данных",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        public FormEmployee(IEmployeeRepository employeeRepository, IPositionRepository positionRepository)
        {
            InitializeComponent();
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
            _positionRepository = positionRepository ?? throw new ArgumentNullException(nameof(positionRepository));
            comboBoxPosition.DisplayMember = nameof(Position.Name);
            comboBoxPosition.ValueMember = nameof(Position.Id);
            comboBoxPosition.DataSource = _positionRepository.ReadPositions().ToList();
            comboBoxPosition.SelectedIndex = -1;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try {
                if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxSecondName.Text) ||
                    comboBoxPosition.SelectedValue is null) throw new Exception("Заполните имя, фамилию и должность.");
                if (_employeeId.HasValue) {
                    _employeeRepository.UpdateEmployee(CreateEmployee(_employeeId.Value));
                }
                else {
                    _employeeRepository.CreateEmployee(CreateEmployee(0));
                }
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка при сохранении",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private Employee CreateEmployee(long id) =>
            Employee.CreateEntity(
                id,
                textBoxFirstName.Text.Trim(),
                textBoxSecondName.Text.Trim(),
                Convert.ToInt32(comboBoxPosition.SelectedValue)
            );
    }
}
