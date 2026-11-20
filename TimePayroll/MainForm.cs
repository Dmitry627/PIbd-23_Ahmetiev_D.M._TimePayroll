using TimePayroll.Forms;
using Unity;

namespace TimePayroll
{
    // Главная форма с меню приложения
    public partial class MainForm : Form
    {
        private readonly IUnityContainer _container;

        // Создает главную форму и ее элементы
        public MainForm(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        private void EmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                using var form = _container.Resolve<FormEmployees>();
                form.ShowDialog(this);
            }
            catch (Exception ex) {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "Не удалось открыть список работников",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void PositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                using var form = _container.Resolve<FormPositions>();
                form.ShowDialog(this);
            }
            catch (Exception ex) {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "Не удалось открыть список должностей",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                using var form = _container.Resolve<FormProjects>();
                form.ShowDialog(this);
            }
            catch (Exception ex) {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "Не удалось открыть список проектов",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void WorkEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                using var form = _container.Resolve<FormWorkEntries>();
                form.ShowDialog(this);
            }
            catch (Exception ex) {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "Не удалось открыть журнал рабочего времени",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void EmployeeBonusesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                using var form = _container.Resolve<FormEmployeeBonuses>();
                form.ShowDialog(this);
            }
            catch (Exception ex) {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "Не удалось открыть список надбавок",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void PayrollsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                using var form = _container.Resolve<FormPayrolls>();
                form.ShowDialog(this);
            }
            catch (Exception ex) {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "Не удалось открыть список начислений зарплаты",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
