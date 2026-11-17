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
    public partial class FormPositions : Form
    {
        private readonly IUnityContainer _container;

        private readonly IPositionRepository _positionRepository;

        public FormPositions(IUnityContainer container, IPositionRepository positionRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _positionRepository = positionRepository ?? throw new ArgumentNullException(nameof(positionRepository));
        }

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

        private void LoadList() => DataGridViewPositions.DataSource = _positionRepository.ReadPositions().ToList();
    
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
