namespace TimePayroll.Forms
{
    // Разметка и элементы формы списка работников
    partial class FormEmployees
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
            dataGridViewEmployees = new DataGridView();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            SuspendLayout();
            //
            // dataGridViewEmployees
            //
            dataGridViewEmployees.AllowUserToAddRows = false;
            dataGridViewEmployees.AllowUserToDeleteRows = false;
            dataGridViewEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Dock = DockStyle.Left;
            dataGridViewEmployees.Location = new Point(0, 0);
            dataGridViewEmployees.MultiSelect = false;
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.ReadOnly = true;
            dataGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployees.Size = new Size(718, 360);
            dataGridViewEmployees.TabIndex = 0;
            //
            // buttonAdd
            //
            buttonAdd.Location = new Point(724, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(124, 73);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            //
            // buttonEdit
            //
            buttonEdit.Location = new Point(724, 91);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(124, 73);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            //
            // buttonCancel
            //
            buttonCancel.Location = new Point(724, 170);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(124, 73);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            //
            // FormEmployees
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 360);
            Controls.Add(buttonCancel);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewEmployees);
            Name = "FormEmployees";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Работники";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEmployees;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonCancel;
    }
}