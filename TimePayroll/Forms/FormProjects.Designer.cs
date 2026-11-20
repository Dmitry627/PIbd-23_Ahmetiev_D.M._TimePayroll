namespace TimePayroll.Forms
{
    // Разметка и элементы формы списка проектов
    partial class FormProjects
    {
        private System.ComponentModel.IContainer components = null;

        // Освобождает ресурсы элементов формы
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Создает элементы формы и задает их свойства
        private void InitializeComponent()
        {
            dataGridViewProjects = new DataGridView();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjects).BeginInit();
            SuspendLayout();
            //
            // dataGridViewProjects
            //
            dataGridViewProjects.AllowUserToAddRows = false;
            dataGridViewProjects.AllowUserToDeleteRows = false;
            dataGridViewProjects.AllowUserToResizeColumns = false;
            dataGridViewProjects.AllowUserToResizeRows = false;
            dataGridViewProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjects.Dock = DockStyle.Left;
            dataGridViewProjects.Location = new Point(0, 0);
            dataGridViewProjects.MultiSelect = false;
            dataGridViewProjects.Name = "dataGridViewProjects";
            dataGridViewProjects.ReadOnly = true;
            dataGridViewProjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProjects.Size = new Size(723, 360);
            dataGridViewProjects.TabIndex = 0;
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
            // buttonEdit
            //
            buttonEdit.Location = new Point(729, 90);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(119, 72);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            //
            // buttonDelete
            //
            buttonDelete.Location = new Point(729, 168);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(119, 72);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            //
            // FormProjects
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 360);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewProjects);
            Name = "FormProjects";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Проекты";
            Load += FormProjects_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjects).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Хранит таблицу проектов
        private DataGridView dataGridViewProjects;
        // Хранит кнопку добавления записи
        private Button buttonAdd;
        // Хранит кнопку изменения записи
        private Button buttonEdit;
        // Хранит кнопку удаления записи
        private Button buttonDelete;
    }
}
