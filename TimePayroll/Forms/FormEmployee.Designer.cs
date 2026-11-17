namespace TimePayroll.Forms
{
    // Разметка и элементы формы одного работника
    partial class FormEmployee
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
            labelFirstName = new Label();
            labelSecondName = new Label();
            labelPosition = new Label();
            textBoxFirstName = new TextBox();
            textBoxSecondName = new TextBox();
            comboBoxPosition = new ComboBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            //
            // labelFirstName
            //
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(45, 32);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(31, 15);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "Имя";
            //
            // labelSecondName
            //
            labelSecondName.AutoSize = true;
            labelSecondName.Location = new Point(45, 72);
            labelSecondName.Name = "labelSecondName";
            labelSecondName.Size = new Size(58, 15);
            labelSecondName.TabIndex = 1;
            labelSecondName.Text = "Фамилия";
            //
            // labelPosition
            //
            labelPosition.AutoSize = true;
            labelPosition.Location = new Point(45, 115);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(69, 15);
            labelPosition.TabIndex = 2;
            labelPosition.Text = "Должность";
            //
            // textBoxFirstName
            //
            textBoxFirstName.Location = new Point(194, 29);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(121, 23);
            textBoxFirstName.TabIndex = 3;
            //
            // textBoxSecondName
            //
            textBoxSecondName.Location = new Point(194, 69);
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.Size = new Size(121, 23);
            textBoxSecondName.TabIndex = 4;
            //
            // comboBoxPosition
            //
            comboBoxPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Location = new Point(194, 112);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(121, 23);
            comboBoxPosition.TabIndex = 5;
            //
            // buttonSave
            //
            buttonSave.Location = new Point(75, 178);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            //
            // buttonCancel
            //
            buttonCancel.Location = new Point(211, 178);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            //
            // FormEmployee
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 224);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxPosition);
            Controls.Add(textBoxSecondName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelPosition);
            Controls.Add(labelSecondName);
            Controls.Add(labelFirstName);
            Name = "FormEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Работник";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFirstName;
        private Label labelSecondName;
        private Label labelPosition;
        private TextBox textBoxFirstName;
        private TextBox textBoxSecondName;
        private ComboBox comboBoxPosition;
        private Button buttonSave;
        private Button buttonCancel;
    }
}