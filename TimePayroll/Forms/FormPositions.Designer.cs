namespace TimePayroll.Forms
{
    // Разметка и элементы формы списка должностей
    partial class FormPositions
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
            DataGridViewPositions = new DataGridView();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewPositions).BeginInit();
            SuspendLayout();
            //
            // DataGridViewPositions
            //
            DataGridViewPositions.AllowUserToAddRows = false;
            DataGridViewPositions.AllowUserToDeleteRows = false;
            DataGridViewPositions.AllowUserToResizeColumns = false;
            DataGridViewPositions.AllowUserToResizeRows = false;
            DataGridViewPositions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewPositions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewPositions.Dock = DockStyle.Left;
            DataGridViewPositions.Location = new Point(0, 0);
            DataGridViewPositions.MultiSelect = false;
            DataGridViewPositions.Name = "DataGridViewPositions";
            DataGridViewPositions.ReadOnly = true;
            DataGridViewPositions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewPositions.Size = new Size(723, 360);
            DataGridViewPositions.TabIndex = 0;
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
            // FormPositions
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 360);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(DataGridViewPositions);
            Name = "FormPositions";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Должности";
            Load += FormPositions_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewPositions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewPositions;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
    }
}
