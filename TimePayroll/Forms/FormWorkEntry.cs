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
    // Форма добавления записи рабочего времени
    public partial class FormWorkEntry : Form
    {
        // Хранит репозиторий записей рабочего времени
        private readonly IWorkEntryRepository _workEntryRepository;

        // Создает форму и загружает данные для выбора
        public FormWorkEntry(IWorkEntryRepository workEntryRepository, IEmployeeRepository employeeRepository, IProjectRepository projectRepository)
        {
            InitializeComponent();
            _workEntryRepository = workEntryRepository ?? throw new ArgumentNullException(nameof(workEntryRepository));

            comboBoxEmployee.DisplayMember = nameof(Employee.FirstName);
            comboBoxEmployee.ValueMember = nameof(Employee.Id);
            comboBoxEmployee.DataSource = employeeRepository.ReadEmployees().ToList();

            comboBoxProject.DisplayMember = nameof(Project.Name);
            comboBoxProject.ValueMember = nameof(Project.Id);
            comboBoxProject.DataSource = projectRepository.ReadProjects().ToList();

            comboBoxWorkType.DataSource = Enum.GetValues<WorkType>()
                .Where(type => type != WorkType.None)
                .ToList();

            comboBoxEmployee.SelectedIndex = -1;
            comboBoxProject.SelectedIndex = -1;
            comboBoxWorkType.SelectedIndex = -1;
            dateTimePickerWorkDate.Value = DateTime.Today;
        }

        // Проверяет ввод и создает запись рабочего времени
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try {
                if (comboBoxEmployee.SelectedValue is not long employeeId ||
                    comboBoxProject.SelectedValue is not long projectId ||
                    comboBoxWorkType.SelectedItem is not WorkType workType) {
                    throw new InvalidDataException("Выберите работника, проект и вид работы");
                }
                if (numericUpDownHours.Value <= 0) throw new InvalidDataException("Количество часов должно быть больше нуля");

                var entry = WorkEntry.CreateEntity(
                    0,
                    employeeId,
                    projectId,
                    (int)workType,
                    dateTimePickerWorkDate.Value.Date,
                    numericUpDownHours.Value);

                _workEntryRepository.CreateWorkEntry(entry);
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка при сохранении записи",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Закрывает форму без сохранения
        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}
