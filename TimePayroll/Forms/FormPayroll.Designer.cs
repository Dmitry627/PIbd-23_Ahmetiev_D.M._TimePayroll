namespace TimePayroll.Forms
{
    // Разметка формы начисления зарплаты
    partial class FormPayroll
    {
        // Хранит компоненты формы
        private System.ComponentModel.IContainer components = null;

        // Освобождает ресурсы формы
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is not null) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Создает элементы формы и задает их свойства
        private void InitializeComponent()
        {
            labelEmployee = new Label();
            comboBoxEmployee = new ComboBox();
            labelPeriodMonth = new Label();
            dateTimePickerPeriodMonth = new DateTimePicker();
            labelTotalHours = new Label();
            textBoxTotalHours = new TextBox();
            labelBaseSalary = new Label();
            textBoxBaseSalary = new TextBox();
            labelBonusAmount = new Label();
            textBoxBonusAmount = new TextBox();
            labelTotalSalary = new Label();
            textBoxTotalSalary = new TextBox();
            labelCalculationStatus = new Label();
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
            // comboBoxEmployee
            //
            comboBoxEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(166, 29);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(226, 23);
            comboBoxEmployee.TabIndex = 1;
            comboBoxEmployee.SelectedIndexChanged += CalculationInput_Changed;
            comboBoxEmployee.Format += comboBoxEmployee_Format;
            //
            // labelPeriodMonth
            //
            labelPeriodMonth.AutoSize = true;
            labelPeriodMonth.Location = new Point(28, 72);
            labelPeriodMonth.Name = "labelPeriodMonth";
            labelPeriodMonth.TabIndex = 2;
            labelPeriodMonth.Text = "Месяц";
            //
            // dateTimePickerPeriodMonth
            //
            dateTimePickerPeriodMonth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerPeriodMonth.CustomFormat = "MMMM yyyy";
            dateTimePickerPeriodMonth.Format = DateTimePickerFormat.Custom;
            dateTimePickerPeriodMonth.Location = new Point(166, 69);
            dateTimePickerPeriodMonth.Name = "dateTimePickerPeriodMonth";
            dateTimePickerPeriodMonth.ShowUpDown = true;
            dateTimePickerPeriodMonth.Size = new Size(226, 23);
            dateTimePickerPeriodMonth.TabIndex = 3;
            dateTimePickerPeriodMonth.ValueChanged += CalculationInput_Changed;
            //
            // labelTotalHours
            //
            labelTotalHours.AutoSize = true;
            labelTotalHours.Location = new Point(28, 112);
            labelTotalHours.Name = "labelTotalHours";
            labelTotalHours.TabIndex = 4;
            labelTotalHours.Text = "Отработано часов";
            //
            // textBoxTotalHours
            //
            textBoxTotalHours.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTotalHours.Location = new Point(166, 109);
            textBoxTotalHours.Name = "textBoxTotalHours";
            textBoxTotalHours.ReadOnly = true;
            textBoxTotalHours.Size = new Size(226, 23);
            textBoxTotalHours.TabIndex = 5;
            textBoxTotalHours.TabStop = false;
            textBoxTotalHours.TextAlign = HorizontalAlignment.Right;
            //
            // labelBaseSalary
            //
            labelBaseSalary.AutoSize = true;
            labelBaseSalary.Location = new Point(28, 152);
            labelBaseSalary.Name = "labelBaseSalary";
            labelBaseSalary.TabIndex = 6;
            labelBaseSalary.Text = "Основная оплата";
            //
            // textBoxBaseSalary
            //
            textBoxBaseSalary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBaseSalary.Location = new Point(166, 149);
            textBoxBaseSalary.Name = "textBoxBaseSalary";
            textBoxBaseSalary.ReadOnly = true;
            textBoxBaseSalary.Size = new Size(226, 23);
            textBoxBaseSalary.TabIndex = 7;
            textBoxBaseSalary.TabStop = false;
            textBoxBaseSalary.TextAlign = HorizontalAlignment.Right;
            //
            // labelBonusAmount
            //
            labelBonusAmount.AutoSize = true;
            labelBonusAmount.Location = new Point(28, 192);
            labelBonusAmount.Name = "labelBonusAmount";
            labelBonusAmount.TabIndex = 8;
            labelBonusAmount.Text = "Сумма надбавок";
            //
            // textBoxBonusAmount
            //
            textBoxBonusAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBonusAmount.Location = new Point(166, 189);
            textBoxBonusAmount.Name = "textBoxBonusAmount";
            textBoxBonusAmount.ReadOnly = true;
            textBoxBonusAmount.Size = new Size(226, 23);
            textBoxBonusAmount.TabIndex = 9;
            textBoxBonusAmount.TabStop = false;
            textBoxBonusAmount.TextAlign = HorizontalAlignment.Right;
            //
            // labelTotalSalary
            //
            labelTotalSalary.AutoSize = true;
            labelTotalSalary.Location = new Point(28, 232);
            labelTotalSalary.Name = "labelTotalSalary";
            labelTotalSalary.TabIndex = 10;
            labelTotalSalary.Text = "Итого к начислению";
            //
            // textBoxTotalSalary
            //
            textBoxTotalSalary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTotalSalary.Location = new Point(166, 229);
            textBoxTotalSalary.Name = "textBoxTotalSalary";
            textBoxTotalSalary.ReadOnly = true;
            textBoxTotalSalary.Size = new Size(226, 23);
            textBoxTotalSalary.TabIndex = 11;
            textBoxTotalSalary.TabStop = false;
            textBoxTotalSalary.TextAlign = HorizontalAlignment.Right;
            //
            // labelCalculationStatus
            //
            labelCalculationStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCalculationStatus.AutoEllipsis = true;
            labelCalculationStatus.Location = new Point(28, 264);
            labelCalculationStatus.Name = "labelCalculationStatus";
            labelCalculationStatus.Size = new Size(364, 38);
            labelCalculationStatus.TabIndex = 12;
            labelCalculationStatus.Text = "Выберите работника";
            //
            // buttonSave
            //
            buttonSave.Enabled = false;
            buttonSave.Location = new Point(106, 317);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(90, 26);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            //
            // buttonCancel
            //
            buttonCancel.Location = new Point(224, 317);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(90, 26);
            buttonCancel.TabIndex = 14;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            //
            // FormPayroll
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 370);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelCalculationStatus);
            Controls.Add(textBoxTotalSalary);
            Controls.Add(labelTotalSalary);
            Controls.Add(textBoxBonusAmount);
            Controls.Add(labelBonusAmount);
            Controls.Add(textBoxBaseSalary);
            Controls.Add(labelBaseSalary);
            Controls.Add(textBoxTotalHours);
            Controls.Add(labelTotalHours);
            Controls.Add(dateTimePickerPeriodMonth);
            Controls.Add(labelPeriodMonth);
            Controls.Add(comboBoxEmployee);
            Controls.Add(labelEmployee);
            Name = "FormPayroll";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Начисление зарплаты";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Подпись списка работников
        private Label labelEmployee;
        // Список работников для выбора
        private ComboBox comboBoxEmployee;
        // Подпись расчетного месяца
        private Label labelPeriodMonth;
        // Поле выбора месяца и года
        private DateTimePicker dateTimePickerPeriodMonth;
        // Подпись отработанных часов
        private Label labelTotalHours;
        // Показывает количество отработанных часов
        private TextBox textBoxTotalHours;
        // Подпись основной оплаты
        private Label labelBaseSalary;
        // Показывает сумму основной оплаты
        private TextBox textBoxBaseSalary;
        // Подпись суммы надбавок
        private Label labelBonusAmount;
        // Показывает сумму надбавок
        private TextBox textBoxBonusAmount;
        // Подпись итоговой суммы
        private Label labelTotalSalary;
        // Показывает итоговую сумму начисления
        private TextBox textBoxTotalSalary;
        // Показывает подсказку или причину невозможности расчета
        private Label labelCalculationStatus;
        // Кнопка сохранения начисления
        private Button buttonSave;
        // Кнопка отмены ввода
        private Button buttonCancel;
    }
}
