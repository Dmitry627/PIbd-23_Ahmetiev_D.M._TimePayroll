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
    // Форма списка записей рабочего времени
    public partial class FormWorkEntries : Form
    {
        // Создает форму добавления через Unity
        private readonly IUnityContainer _container;

        // Предоставляет список записей рабочего времени
        private readonly IWorkEntryRepository _workEntryRepository;

        // Создает форму и принимает зависимости
        public FormWorkEntries(IUnityContainer container, IWorkEntryRepository workEntryRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _workEntryRepository = workEntryRepository ?? throw new ArgumentNullException(nameof(workEntryRepository));
        }

        // Открывает форму добавления и обновляет таблицу после ее закрытия
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try {
                using var form = _container.Resolve<FormWorkEntry>();
                form.ShowDialog(this);
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

        // Загружает записи в таблицу
        private void LoadList() => dataGridViewWorkEntries.DataSource = _workEntryRepository.ReadWorkEntries().ToList();

        // Загружает таблицу при открытии окна
        private void FormWorkEntries_Load(object sender, EventArgs e)
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
    }
}
