using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TimePayroll.Repositories;
using TimePayroll.Entities.Enums;
using TimePayroll.Entities;
using Unity;

namespace TimePayroll.Forms
{
    // Форма добавления и редактирования проекта
    public partial class FormProject : Form
    {
        // Хранит репозиторий проектов
        private readonly IProjectRepository _projectRepository;

        // Хранит репозиторий работников
        private readonly IEmployeeRepository _employeeRepository;

        // Хранит идентификатор проекта при редактировании
        private long? _projectId;

        public long Id
        {
            set {
                try {
                    var project = _projectRepository.ReadProjectById(value);
                    if (project is null) throw new InvalidDataException("Проект не найден");
                    textBoxProjectName.Text = project.Name;
                    comboBoxProjectType.SelectedItem = (ProjectType)project.Type;
                    comboBoxManager.SelectedValue = project.ManagerId;
                    comboBoxDeveloper.SelectedValue = project.DeveloperId;
                }
                catch (Exception ex) {
                    MessageBox.Show(
                        ex.Message,
                        "Ошибка при получении проекта",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
        // Создает элементы формы проекта
        public FormProject(IProjectRepository projectRepository, IEmployeeRepository employeeRepository)
        {
            InitializeComponent();
            _projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));

            comboBoxProjectType.DataSource = Enum.GetValues<ProjectType>()
                .Where(type => type != ProjectType.None)
                .ToList();
            var employees = _employeeRepository.ReadEmployees()
                .Select(employee => new
                {
                    employee.Id,
                    FullName = $"{employee.FirstName} {employee.SecondName}"
                })
                .ToList();

            comboBoxManager.DisplayMember = "FullName";
            comboBoxManager.ValueMember = "Id";
            comboBoxManager.DataSource = employees;

            comboBoxDeveloper.DisplayMember = "FullName";
            comboBoxDeveloper.ValueMember = "Id";
            comboBoxDeveloper.DataSource = employees.ToList();

            comboBoxProjectType.SelectedIndex = -1;
            comboBoxManager.SelectedIndex = -1;
            comboBoxDeveloper.SelectedIndex = -1;
        }

        // Проверяет поля и передает проект в репозиторий для создания или изменения
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try {
                var name = textBoxProjectName.Name.Trim();
                if (string.IsNullOrWhiteSpace(name) || 
                comboBoxProjectType.SelectedItem is not ProjectType projectType ||
                comboBoxManager.SelectedValue is not long managerId ||
                comboBoxDeveloper.SelectedValue is not long developerId) {
                    throw new InvalidDataException("Заполните все поля проекта");
                }
                var project = Project.CreateEntity(
                    _projectId ?? 0,
                    name,
                    (int)projectType,
                    managerId,
                    developerId
                );
                if (_projectId.HasValue) _projectRepository.UpdateProject(project);
                else _projectRepository.CreateProject(project);
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка при сохранении проекта",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Закрывает форму без сохранения введенных данных
        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}
