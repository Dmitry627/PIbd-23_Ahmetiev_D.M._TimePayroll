namespace TimePayroll.Forms
{
    // Разметка формы назначения надбавки
    partial class FormEmployeeBonus
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

        // Создает поля формы и задает их свойства
        private void InitializeComponent()
        {
            labelEmployee = new Label();
            labelBonusTypes = new Label();
            labelStartDate = new Label();
            labelEndDate = new Label();
            comboBoxEmployee = new ComboBox();
            checkedListBoxBonusTypes = new CheckedListBox();
            dateTimePickerStartDate = new DateTimePicker();
            dateTimePickerEndDate = new DateTimePicker();
            buttonSave = new Button();
            buttonCancel = new Button();
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
            // labelBonusTypes
            //
            labelBonusTypes.AutoSize = true;
            labelBonusTypes.Location = new Point(28, 72);
            labelBonusTypes.Name = "labelBonusTypes";
            labelBonusTypes.TabIndex = 2;
            labelBonusTypes.Text = "Виды надбавок";
            //
            // labelStartDate
            //
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(28, 178);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.TabIndex = 4;
            labelStartDate.Text = "Дата начала";
            //
            // labelEndDate
            //
            labelEndDate.AutoSize = true;
            labelEndDate.Location = new Point(28, 218);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.TabIndex = 6;
            labelEndDate.Text = "Дата окончания";
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
            // checkedListBoxBonusTypes
            //
            checkedListBoxBonusTypes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBoxBonusTypes.CheckOnClick = true;
            checkedListBoxBonusTypes.FormattingEnabled = true;
            checkedListBoxBonusTypes.IntegralHeight = false;
            checkedListBoxBonusTypes.Location = new Point(166, 69);
            checkedListBoxBonusTypes.Name = "checkedListBoxBonusTypes";
            checkedListBoxBonusTypes.Size = new Size(226, 89);
            checkedListBoxBonusTypes.TabIndex = 3;
            //
            // dateTimePickerStartDate
            //
            dateTimePickerStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerStartDate.Format = DateTimePickerFormat.Short;
            dateTimePickerStartDate.Location = new Point(166, 175);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(226, 23);
            dateTimePickerStartDate.TabIndex = 5;
            //
            // dateTimePickerEndDate
            //
            dateTimePickerEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerEndDate.Format = DateTimePickerFormat.Short;
            dateTimePickerEndDate.Location = new Point(166, 215);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(226, 23);
            dateTimePickerEndDate.TabIndex = 7;
            //
            // buttonSave
            //
            buttonSave.Location = new Point(106, 267);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(90, 26);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            //
            // buttonCancel
            //
            buttonCancel.Location = new Point(224, 267);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(90, 26);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            //
            // FormEmployeeBonus
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 320);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(dateTimePickerEndDate);
            Controls.Add(dateTimePickerStartDate);
            Controls.Add(checkedListBoxBonusTypes);
            Controls.Add(comboBoxEmployee);
            Controls.Add(labelEndDate);
            Controls.Add(labelStartDate);
            Controls.Add(labelBonusTypes);
            Controls.Add(labelEmployee);
            Name = "FormEmployeeBonus";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Назначение надбавки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Подпись списка работников
        private Label labelEmployee;
        // Подпись списка видов надбавок
        private Label labelBonusTypes;
        // Подпись даты начала
        private Label labelStartDate;
        // Подпись даты окончания
        private Label labelEndDate;
        // Список работников для выбора
        private ComboBox comboBoxEmployee;
        // Список видов надбавок с галочками
        private CheckedListBox checkedListBoxBonusTypes;
        // Поле даты начала действия надбавки
        private DateTimePicker dateTimePickerStartDate;
        // Поле даты окончания действия надбавки
        private DateTimePicker dateTimePickerEndDate;
        // Кнопка сохранения надбавки
        private Button buttonSave;
        // Кнопка отмены ввода
        private Button buttonCancel;
    }
}
