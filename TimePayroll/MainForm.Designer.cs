namespace TimePayroll
{
    // Разметка и элементы главной формы
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Освобождает ресурсы элементов формы при ее закрытии
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Создает элементы формы, задает свойства и подключает события
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            справочникToolStripMenuItem = new ToolStripMenuItem();
            работникиToolStripMenuItem = new ToolStripMenuItem();
            должностиToolStripMenuItem = new ToolStripMenuItem();
            проектыToolStripMenuItem = new ToolStripMenuItem();
            операцииToolStripMenuItem = new ToolStripMenuItem();
            учетВремениToolStripMenuItem = new ToolStripMenuItem();
            надбавкиСотрудникамToolStripMenuItem = new ToolStripMenuItem();
            начислениеЗарплатыToolStripMenuItem = new ToolStripMenuItem();
            отчетыToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникToolStripMenuItem, операцииToolStripMenuItem, отчетыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(959, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // справочникToolStripMenuItem
            // 
            справочникToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { работникиToolStripMenuItem, должностиToolStripMenuItem, проектыToolStripMenuItem });
            справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            справочникToolStripMenuItem.Size = new Size(87, 20);
            справочникToolStripMenuItem.Text = "Справочник";
            // 
            // работникиToolStripMenuItem
            // 
            работникиToolStripMenuItem.Name = "работникиToolStripMenuItem";
            работникиToolStripMenuItem.Size = new Size(137, 22);
            работникиToolStripMenuItem.Text = "Работники";
            работникиToolStripMenuItem.Click += EmployeesToolStripMenuItem_Click;
            // 
            // должностиToolStripMenuItem
            // 
            должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            должностиToolStripMenuItem.Size = new Size(137, 22);
            должностиToolStripMenuItem.Text = "Должности";
            должностиToolStripMenuItem.Click += PositionsToolStripMenuItem_Click;
            // 
            // проектыToolStripMenuItem
            // 
            проектыToolStripMenuItem.Name = "проектыToolStripMenuItem";
            проектыToolStripMenuItem.Size = new Size(137, 22);
            проектыToolStripMenuItem.Text = "Проекты";
            проектыToolStripMenuItem.Click += ProjectsToolStripMenuItem_Click;
            // 
            // операцииToolStripMenuItem
            // 
            операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { учетВремениToolStripMenuItem, надбавкиСотрудникамToolStripMenuItem, начислениеЗарплатыToolStripMenuItem });
            операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            операцииToolStripMenuItem.Size = new Size(75, 20);
            операцииToolStripMenuItem.Text = "Операции";
            // 
            // учетВремениToolStripMenuItem
            // 
            учетВремениToolStripMenuItem.Name = "учетВремениToolStripMenuItem";
            учетВремениToolStripMenuItem.Size = new Size(202, 22);
            учетВремениToolStripMenuItem.Text = "Учет времени";
            учетВремениToolStripMenuItem.Click += WorkEntriesToolStripMenuItem_Click;
            // 
            // надбавкиСотрудникамToolStripMenuItem
            // 
            надбавкиСотрудникамToolStripMenuItem.Name = "надбавкиСотрудникамToolStripMenuItem";
            надбавкиСотрудникамToolStripMenuItem.Size = new Size(202, 22);
            надбавкиСотрудникамToolStripMenuItem.Text = "Надбавки сотрудникам";
            надбавкиСотрудникамToolStripMenuItem.Click += EmployeeBonusesToolStripMenuItem_Click;
            // 
            // начислениеЗарплатыToolStripMenuItem
            // 
            начислениеЗарплатыToolStripMenuItem.Name = "начислениеЗарплатыToolStripMenuItem";
            начислениеЗарплатыToolStripMenuItem.Size = new Size(202, 22);
            начислениеЗарплатыToolStripMenuItem.Text = "Начисление зарплаты";
            начислениеЗарплатыToolStripMenuItem.Click += PayrollsToolStripMenuItem_Click;
            // 
            // отчетыToolStripMenuItem
            // 
            отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            отчетыToolStripMenuItem.Size = new Size(60, 20);
            отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(959, 679);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Учёт времени и зарплаты";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Хранит главное меню формы
        private MenuStrip menuStrip1;
        // Хранит пункт меню справочников
        private ToolStripMenuItem справочникToolStripMenuItem;
        // Хранит пункт меню работников
        private ToolStripMenuItem работникиToolStripMenuItem;
        // Хранит пункт меню должностей
        private ToolStripMenuItem должностиToolStripMenuItem;
        // Хранит пункт меню проектов
        private ToolStripMenuItem проектыToolStripMenuItem;
        // Хранит пункт меню операций
        private ToolStripMenuItem операцииToolStripMenuItem;
        // Хранит пункт меню учета времени
        private ToolStripMenuItem учетВремениToolStripMenuItem;
        // Хранит пункт меню надбавок сотрудникам
        private ToolStripMenuItem надбавкиСотрудникамToolStripMenuItem;
        // Хранит пункт меню начисления зарплаты
        private ToolStripMenuItem начислениеЗарплатыToolStripMenuItem;
        // Хранит пункт меню отчетов
        private ToolStripMenuItem отчетыToolStripMenuItem;
    }
}
