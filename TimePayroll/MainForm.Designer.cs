namespace TimePayroll
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
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
            // 
            // должностиToolStripMenuItem
            // 
            должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            должностиToolStripMenuItem.Size = new Size(137, 22);
            должностиToolStripMenuItem.Text = "Должности";
            // 
            // проектыToolStripMenuItem
            // 
            проектыToolStripMenuItem.Name = "проектыToolStripMenuItem";
            проектыToolStripMenuItem.Size = new Size(137, 22);
            проектыToolStripMenuItem.Text = "Проекты";
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
            // 
            // надбавкиСотрудникамToolStripMenuItem
            // 
            надбавкиСотрудникамToolStripMenuItem.Name = "надбавкиСотрудникамToolStripMenuItem";
            надбавкиСотрудникамToolStripMenuItem.Size = new Size(202, 22);
            надбавкиСотрудникамToolStripMenuItem.Text = "Надбавки сотрудникам";
            // 
            // начислениеЗарплатыToolStripMenuItem
            // 
            начислениеЗарплатыToolStripMenuItem.Name = "начислениеЗарплатыToolStripMenuItem";
            начислениеЗарплатыToolStripMenuItem.Size = new Size(202, 22);
            начислениеЗарплатыToolStripMenuItem.Text = "Начисление зарплаты";
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
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникToolStripMenuItem;
        private ToolStripMenuItem работникиToolStripMenuItem;
        private ToolStripMenuItem должностиToolStripMenuItem;
        private ToolStripMenuItem проектыToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem учетВремениToolStripMenuItem;
        private ToolStripMenuItem надбавкиСотрудникамToolStripMenuItem;
        private ToolStripMenuItem начислениеЗарплатыToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
    }
}
