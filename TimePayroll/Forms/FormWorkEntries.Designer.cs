namespace TimePayroll.Forms
{
    // Разметка списка записей рабочего времени
    partial class FormWorkEntries
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

        // Создает таблицу и кнопку добавления
        private void InitializeComponent()
        {
            dataGridViewWorkEntries = new DataGridView();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkEntries).BeginInit();
            SuspendLayout();
            //
            // dataGridViewWorkEntries
            //
            dataGridViewWorkEntries.AllowUserToAddRows = false;
            dataGridViewWorkEntries.AllowUserToDeleteRows = false;
            dataGridViewWorkEntries.AllowUserToResizeColumns = false;
            dataGridViewWorkEntries.AllowUserToResizeRows = false;
            dataGridViewWorkEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewWorkEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorkEntries.Dock = DockStyle.Left;
            dataGridViewWorkEntries.Location = new Point(0, 0);
            dataGridViewWorkEntries.MultiSelect = false;
            dataGridViewWorkEntries.Name = "dataGridViewWorkEntries";
            dataGridViewWorkEntries.ReadOnly = true;
            dataGridViewWorkEntries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewWorkEntries.Size = new Size(723, 360);
            dataGridViewWorkEntries.TabIndex = 0;
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
            // FormWorkEntries
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 360);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewWorkEntries);
            Name = "FormWorkEntries";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Учет рабочего времени";
            Load += FormWorkEntries_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkEntries).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Таблица записей рабочего времени
        private DataGridView dataGridViewWorkEntries;
        // Кнопка добавления записи
        private Button buttonAdd;
    }
}
