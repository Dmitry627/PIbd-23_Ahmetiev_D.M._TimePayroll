namespace TimePayroll.Forms
{
    // Разметка формы добавления записи рабочего времени
    partial class FormWorkEntry
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

        // Создает элементы формы и задает их свойства
        private void InitializeComponent()
        {
            labelEmployee = new Label();
            labelProject = new Label();
            labelWorkType = new Label();
            labelWorkDate = new Label();
            labelHours = new Label();
            comboBoxEmployee = new ComboBox();
            comboBoxProject = new ComboBox();
            comboBoxWorkType = new ComboBox();
            dateTimePickerWorkDate = new DateTimePicker();
            numericUpDownHours = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).BeginInit();
            SuspendLayout();
            //
            // labelEmployee
            //
            labelEmployee.AutoSize = true;
            labelEmployee.Location = new Point(28, 32);
            labelEmployee.Name = "labelEmployee";
            labelEmployee.TabIndex = 0;
            labelEmployee.Text = "Работник";
            //
            // labelProject
            //
            labelProject.AutoSize = true;
            labelProject.Location = new Point(28, 72);
            labelProject.Name = "labelProject";
            labelProject.TabIndex = 2;
            labelProject.Text = "Проект";
            //
            // labelWorkType
            //
            labelWorkType.AutoSize = true;
            labelWorkType.Location = new Point(28, 112);
            labelWorkType.Name = "labelWorkType";
            labelWorkType.TabIndex = 4;
            labelWorkType.Text = "Вид работы";
            //
            // labelWorkDate
            //
            labelWorkDate.AutoSize = true;
            labelWorkDate.Location = new Point(28, 152);
            labelWorkDate.Name = "labelWorkDate";
            labelWorkDate.TabIndex = 6;
            labelWorkDate.Text = "Дата работы";
            //
            // labelHours
            //
            labelHours.AutoSize = true;
            labelHours.Location = new Point(28, 192);
            labelHours.Name = "labelHours";
            labelHours.TabIndex = 8;
            labelHours.Text = "Часы";
            //
            // comboBoxEmployee
            //
            comboBoxEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(166, 29);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(226, 23);
            comboBoxEmployee.TabIndex = 1;
            //
            // comboBoxProject
            //
            comboBoxProject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxProject.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProject.FormattingEnabled = true;
            comboBoxProject.Location = new Point(166, 69);
            comboBoxProject.Name = "comboBoxProject";
            comboBoxProject.Size = new Size(226, 23);
            comboBoxProject.TabIndex = 3;
            //
            // comboBoxWorkType
            //
            comboBoxWorkType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxWorkType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWorkType.FormattingEnabled = true;
            comboBoxWorkType.Location = new Point(166, 109);
            comboBoxWorkType.Name = "comboBoxWorkType";
            comboBoxWorkType.Size = new Size(226, 23);
            comboBoxWorkType.TabIndex = 5;
            //
            // dateTimePickerWorkDate
            //
            dateTimePickerWorkDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerWorkDate.Enabled = false;
            dateTimePickerWorkDate.Format = DateTimePickerFormat.Short;
            dateTimePickerWorkDate.Location = new Point(166, 149);
            dateTimePickerWorkDate.Name = "dateTimePickerWorkDate";
            dateTimePickerWorkDate.Size = new Size(226, 23);
            dateTimePickerWorkDate.TabIndex = 7;
            //
            // numericUpDownHours
            //
            numericUpDownHours.DecimalPlaces = 2;
            numericUpDownHours.Location = new Point(166, 189);
            numericUpDownHours.Name = "numericUpDownHours";
            numericUpDownHours.Size = new Size(120, 23);
            numericUpDownHours.TabIndex = 9;
            //
            // buttonSave
            //
            buttonSave.Location = new Point(106, 241);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(90, 26);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            //
            // buttonCancel
            //
            buttonCancel.Location = new Point(224, 241);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(90, 26);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            //
            // FormWorkEntry
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 294);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownHours);
            Controls.Add(dateTimePickerWorkDate);
            Controls.Add(comboBoxWorkType);
            Controls.Add(comboBoxProject);
            Controls.Add(comboBoxEmployee);
            Controls.Add(labelHours);
            Controls.Add(labelWorkDate);
            Controls.Add(labelWorkType);
            Controls.Add(labelProject);
            Controls.Add(labelEmployee);
            Name = "FormWorkEntry";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Запись рабочего времени";
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Подпись списка работников
        private Label labelEmployee;
        // Подпись списка проектов
        private Label labelProject;
        // Подпись списка видов работ
        private Label labelWorkType;
        // Подпись поля даты работы
        private Label labelWorkDate;
        // Подпись поля количества часов
        private Label labelHours;
        // Список работников
        private ComboBox comboBoxEmployee;
        // Список проектов
        private ComboBox comboBoxProject;
        // Список видов работ
        private ComboBox comboBoxWorkType;
        // Отображает дату работы
        private DateTimePicker dateTimePickerWorkDate;
        // Поле ввода количества часов
        private NumericUpDown numericUpDownHours;
        // Кнопка сохранения записи
        private Button buttonSave;
        // Кнопка отмены ввода
        private Button buttonCancel;
    }
}
