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
    // Форма списка начислений зарплаты
    public partial class FormPayrolls : Form
    {
        // Хранит контейнер Unity для открытия формы начисления
        private readonly IUnityContainer _container;

        // Предоставляет список начислений зарплаты
        private readonly IPayrollRepository _payrollRepository;

        // Создает форму списка и принимает зависимости
        public FormPayrolls(IUnityContainer container, IPayrollRepository payrollRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _payrollRepository = payrollRepository ?? throw new ArgumentNullException(nameof(payrollRepository));
        }

        // Загружает таблицу при открытии формы
        private void FormPayrolls_Load(object sender, EventArgs e)
        {
            try {
                LoadList();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    this, ex.Message, "Ошибка при загрузке начислений",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // Открывает форму создания начисления и обновляет таблицу
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try {
                using var form = _container.Resolve<FormPayroll>();
                form.ShowDialog(this);
                LoadList();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    this, ex.Message, "Ошибка при добавлении начисления",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // Получает начисления из репозитория и выводит их в таблицу
        private void LoadList()
        {
            dataGridViewPayrolls.DataSource = _payrollRepository.ReadPayrolls().ToList();
        }
    }
}
