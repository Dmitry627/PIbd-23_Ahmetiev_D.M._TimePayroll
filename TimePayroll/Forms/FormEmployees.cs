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
    // Форма списка работников
    public partial class FormEmployees : Form
    {
        // Хранит контейнер Unity для создания форм
        private readonly IUnityContainer _unityContainer;

        // Хранит репозиторий работников
        private readonly IEmployeeRepository _employeeRepository;

        // Создает форму списка работников и ее элементы
        public FormEmployees(IUnityContainer container, IEmployeeRepository employeeRepository)
        {
            InitializeComponent();
            _unityContainer = container ?? throw new ArgumentNullException(nameof(container)); ;
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        // Загружает список работников при открытии формы и показывает ошибки
        private void FormEmployees_Load(object sender, EventArgs e)
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

        // Открывает форму добавления работника
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try {
                _unityContainer.Resolve<FormEmployee>().ShowDialog();
                LoadList();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка при добавлении",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Открывает выбранного работника для редактирования
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            try {
                var form = _unityContainer.Resolve<FormEmployee>();
                form.Id = findId;
                form.ShowDialog();
                LoadList();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка при изменении",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Удаляет выбранного работника после подтверждения
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            if (MessageBox.Show(
                "Удалить выбранного работника?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes) return;
            try {
                _employeeRepository.DeleteEmployee(findId);
                LoadList();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка при удалении",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Проверяет выбор строки и возвращает идентификатор работника через out
        private bool TryGetIdentifierFromSelectedRow(out long id)
        {
            id = 0;
            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Выберите работника в таблице",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            id = Convert.ToInt64(dataGridViewEmployees.SelectedRows[0].Cells["Id"].Value);
            return true;
        }

        // Получает работников из репозитория и выводит их в таблицу
        private void LoadList() => dataGridViewEmployees.DataSource = _employeeRepository.ReadEmployees().ToList();
    }
}
