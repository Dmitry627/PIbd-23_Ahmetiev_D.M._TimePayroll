namespace TimePayroll.Forms
{
    // Разметка списка надбавок работников
    partial class FormEmployeeBonuses
    {
        // Хранит компоненты формы
        private System.ComponentModel.IContainer components = null;

        // Освобождает ресурсы формы
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Создает таблицу и кнопки работы с надбавками
        private void InitializeComponent()
        {
            dataGridViewEmployeeBonuses = new DataGridView();
            buttonAdd = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeeBonuses).BeginInit();
            SuspendLayout();
            //
            // dataGridViewEmployeeBonuses
            //
            dataGridViewEmployeeBonuses.AllowUserToAddRows = false;
            dataGridViewEmployeeBonuses.AllowUserToDeleteRows = false;
            dataGridViewEmployeeBonuses.AllowUserToResizeColumns = false;
            dataGridViewEmployeeBonuses.AllowUserToResizeRows = false;
            dataGridViewEmployeeBonuses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployeeBonuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployeeBonuses.Dock = DockStyle.Left;
            dataGridViewEmployeeBonuses.Location = new Point(0, 0);
            dataGridViewEmployeeBonuses.MultiSelect = false;
            dataGridViewEmployeeBonuses.Name = "dataGridViewEmployeeBonuses";
            dataGridViewEmployeeBonuses.ReadOnly = true;
            dataGridViewEmployeeBonuses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployeeBonuses.Size = new Size(723, 360);
            dataGridViewEmployeeBonuses.TabIndex = 0;
            //
            // buttonAdd
            //
            buttonAdd.Location = new Point(729, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(119, 72);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            //
            // buttonDelete
            //
            buttonDelete.Location = new Point(729, 90);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(119, 72);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            //
            // FormEmployeeBonuses
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 360);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewEmployeeBonuses);
            Name = "FormEmployeeBonuses";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Надбавки работников";
            Load += FormEmployeeBonuses_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeeBonuses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Таблица назначенных надбавок
        private DataGridView dataGridViewEmployeeBonuses;
        // Кнопка добавления надбавки
        private Button buttonAdd;
        // Кнопка удаления выбранной надбавки
        private Button buttonDelete;
    }
}
