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
    // Форма добавления и редактирования одной должности
    public partial class FormPosition : Form
    {
        private readonly IPositionRepository _positionRepository;

        private int? _positionId;

        // При присваивании номера загружает запись в поля формы и запоминает ее для редактирования
        public int Id
        {
            set {
                try {
                    var position = _positionRepository.ReadPositionById(value);
                    if (position is null) throw new InvalidDataException(nameof(position));
                    TextBoxPositionName.Text = position.Name;
                    NumericUpDownHourlyRate.Value = position.HourlyRate;
                    _positionId = value;
                }
                catch (Exception ex) {
                    MessageBox.Show(
                        ex.Message,
                        "Ошибка при получении данных",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        // Создает форму и принимает репозиторий должностей
        public FormPosition(IPositionRepository positionRepository)
        {
            InitializeComponent();
            _positionRepository = positionRepository ?? throw new ArgumentNullException(nameof(positionRepository));
        }

        // Проверяет поля и передает данные должности в репозиторий для создания или изменения
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = TextBoxPositionName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name)) {
                MessageBox.Show("Введите название должности.");
                TextBoxPositionName.Focus();
                return;
            }
            if (NumericUpDownHourlyRate.Value <= 0) {
                MessageBox.Show("Почасовая ставка должна быть больше нуля.");
                NumericUpDownHourlyRate.Focus();
                return;
            }
            try {
                if (_positionId.HasValue) {
                    _positionRepository.UpdatePosition(CreatePosition(_positionId.Value));
                }
                else {
                    _positionRepository.CreatePosition(CreatePosition(0));
                }
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка при сохранении",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Закрывает форму без передачи изменений в репозиторий
        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        // Собирает объект должности из значений полей формы
        private Position CreatePosition(int id) =>
            Position.CreateEntity(
                id,
                TextBoxPositionName.Text.Trim(),
                NumericUpDownHourlyRate.Value);
    }
}
