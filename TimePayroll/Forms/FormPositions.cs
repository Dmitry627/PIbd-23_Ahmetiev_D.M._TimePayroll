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
    // Форма списка должностей с добавлением, изменением и удалением
    public partial class FormPositions : Form
    {
        // Хранит контейнер Unity для создания форм
        private readonly IUnityContainer _container;

        // Хранит репозиторий должностей
        private readonly IPositionRepository _positionRepository;

        // Создает форму и принимает контейнер Unity и репозиторий должностей
        public FormPositions(IUnityContainer container, IPositionRepository positionRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _positionRepository = positionRepository ?? throw new ArgumentNullException(nameof(positionRepository));
        }

        // Загружает список должностей при открытии формы и показывает ошибки
        private void FormPositions_Load(object sender, EventArgs e)
        {
            try
            {
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка при загрузке",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Открывает форму добавления и обновляет список после ее закрытия
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try {
                _container.Resolve<FormPosition>().ShowDialog();
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

        // Передает номер выбранной записи в форму редактирования и обновляет список
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            try {
                var form = _container.Resolve<FormPosition>();
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

        // Запрашивает подтверждение, вызывает удаление выбранной записи и обновляет список
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId)) return;
            if (MessageBox.Show(
                "Удалить выбранную должность?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes) return;
            try {
                var position = _positionRepository.ReadPositionById(findId);
                if (position is null) throw new InvalidDataException("Должность не найдена");
                _positionRepository.DeletePosition(position);
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

        // Получает список должностей из репозитория и выводит его в таблицу
        private void LoadList() => DataGridViewPositions.DataSource = _positionRepository.ReadPositions().ToList();
    
        // Проверяет выбор строки и возвращает ее идентификатор через out
        private bool TryGetIdentifierFromSelectedRow(out int id)
        {
            id = 0;
            if (DataGridViewPositions.SelectedRows.Count < 1) {
                MessageBox.Show(
                    "Нет выбранной записи",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            id = Convert.ToInt32(DataGridViewPositions.SelectedRows[0].Cells["Id"].Value);
            return true;
        }
    }
}
