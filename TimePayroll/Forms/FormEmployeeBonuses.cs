using TimePayroll.Entities;
using TimePayroll.Repositories;
using Unity;

namespace TimePayroll.Forms
{
    // Форма списка надбавок работников
    public partial class FormEmployeeBonuses : Form
    {
        // Хранит контейнер Unity для открытия формы назначения надбавки
        private readonly IUnityContainer _container;

        // Хранит репозиторий надбавок работников
        private readonly IEmployeeBonusRepository _employeeBonusRepository;

        // Создает форму списка и принимает зависимости
        public FormEmployeeBonuses(IUnityContainer container, IEmployeeBonusRepository employeeBonusRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _employeeBonusRepository = employeeBonusRepository ?? throw new ArgumentNullException(nameof(employeeBonusRepository));
        }

        // Открывает форму назначения надбавки и обновляет список
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try {
                using var form = _container.Resolve<FormEmployeeBonus>();
                form.ShowDialog(this);
                LoadList();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    this, ex.Message, "Ошибка при добавлении надбавки",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Удаляет выбранную надбавку после подтверждения и обновляет список
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewEmployeeBonuses.SelectedRows;
            if (selectedRows.Count == 0 || selectedRows[0].DataBoundItem is not EmployeeBonus bonus) {
                MessageBox.Show(
                    this, "Выберите надбавку в таблице", "Удаление надбавки",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(
                this, "Удалить выбранную надбавку?", "Удаление надбавки",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

            try {
                _employeeBonusRepository.DeleteEmployeeBonus(bonus);
                LoadList();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    this, ex.Message, "Ошибка при удалении надбавки",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Загружает надбавки из репозитория в таблицу
        private void LoadList() => dataGridViewEmployeeBonuses.DataSource = _employeeBonusRepository.ReadEmployeeBonuses().ToList();

        // Загружает надбавки при открытии формы
        private void FormEmployeeBonuses_Load(object sender, EventArgs e)
        {
            try {
                LoadList();
            }
            catch (Exception ex) {
                MessageBox.Show(
                    this, ex.Message, "Ошибка при загрузке надбавок",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
