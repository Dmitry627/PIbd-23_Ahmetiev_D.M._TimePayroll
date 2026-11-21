using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TimePayroll.Repositories;
using Unity;

namespace TimePayroll.Forms
{
    // Форма списка проектов
    public partial class FormProjects : Form
    {
        // Хранит контейнер Unity для создания форм
        private readonly IUnityContainer _container;

        // Хранит репозиторий проектов
        private readonly IProjectRepository _projectRepository;

        // Создает форму и принимает контейнер и репозиторий
        public FormProjects(IUnityContainer container, IProjectRepository projectRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _projectRepository = projectRepository
                ?? throw new ArgumentNullException(nameof(projectRepository));
        }

        // Открывает форму добавления проекта и обновляет таблицу
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try {
                _container.Resolve<FormProject>().ShowDialog();
                LoadList();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка при добавлении проекта",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Открывает выбранный проект для редактирования и обновляет таблицу
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            try {
                var form = _container.Resolve<FormProject>();
                form.Id = findId;
                form.ShowDialog();
                LoadList();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка при изменении проекта",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Удаляет выбранный проект после подтверждения
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            if (MessageBox.Show(
            "Удалить выбранный проект?",
            "Удаление",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) != DialogResult.Yes) return;

            try {
                var project = _projectRepository.ReadProjectById(findId);
                if (project is null) throw new InvalidDataException("Проект не найден");
                _projectRepository.DeleteProject(project);
                LoadList();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка при удалении проекта",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Загружает список проектов при открытии формы и показывает ошибки
        private void FormProjects_Load(object sender, EventArgs e)
        {
            try {
                LoadList();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка при загрузке",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Заполняет таблицу проектами из репозитория
        private void LoadList() => dataGridViewProjects.DataSource = _projectRepository.ReadProjects().ToList();

        // Получает номер проекта из выбранной строки
        // Проверяет выбор строки и возвращает идентификатор проекта через out
        private bool TryGetIdentifierFromSelectedRow(out long id)
        {
            id = 0;
            if (dataGridViewProjects.SelectedRows.Count == 0) {
                MessageBox.Show("Выберите проект в таблице");
                return false;
            }
            id = Convert.ToInt64(dataGridViewProjects.SelectedRows[0].Cells["Id"].Value);
            return true;
        }
    }
}
