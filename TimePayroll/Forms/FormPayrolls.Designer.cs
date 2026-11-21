namespace TimePayroll.Forms
{
    // Разметка списка начислений зарплаты
    partial class FormPayrolls
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

        // Создает таблицу со столбцами и кнопку добавления
        private void InitializeComponent()
        {
            dataGridViewPayrolls = new DataGridView();
            columnEmployeeId = new DataGridViewTextBoxColumn();
            columnPeriodMonth = new DataGridViewTextBoxColumn();
            columnTotalHours = new DataGridViewTextBoxColumn();
            columnBaseSalary = new DataGridViewTextBoxColumn();
            columnBonusAmount = new DataGridViewTextBoxColumn();
            columnTotalSalary = new DataGridViewTextBoxColumn();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayrolls).BeginInit();
            SuspendLayout();
            //
            // dataGridViewPayrolls
            //
            dataGridViewPayrolls.AllowUserToAddRows = false;
            dataGridViewPayrolls.AllowUserToDeleteRows = false;
            dataGridViewPayrolls.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPayrolls.AutoGenerateColumns = false;
            dataGridViewPayrolls.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPayrolls.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPayrolls.Columns.AddRange(
                new DataGridViewColumn[]
                {
                    columnEmployeeId, columnPeriodMonth, columnTotalHours,
                    columnBaseSalary, columnBonusAmount, columnTotalSalary
                });
            dataGridViewPayrolls.Location = new Point(12, 12);
            dataGridViewPayrolls.MultiSelect = false;
            dataGridViewPayrolls.Name = "dataGridViewPayrolls";
            dataGridViewPayrolls.ReadOnly = true;
            dataGridViewPayrolls.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPayrolls.Size = new Size(707, 336);
            dataGridViewPayrolls.TabIndex = 0;
            //
            // columnEmployeeId
            //
            columnEmployeeId.DataPropertyName = "EmployeeId";
            columnEmployeeId.HeaderText = "Код работника";
            columnEmployeeId.Name = "columnEmployeeId";
            //
            // columnPeriodMonth
            //
            columnPeriodMonth.DataPropertyName = "PeriodMonth";
            columnPeriodMonth.DefaultCellStyle.Format = "MMMM yyyy";
            columnPeriodMonth.HeaderText = "Месяц начисления";
            columnPeriodMonth.Name = "columnPeriodMonth";
            //
            // columnTotalHours
            //
            columnTotalHours.DataPropertyName = "TotalHours";
            columnTotalHours.DefaultCellStyle.Format = "0.##";
            columnTotalHours.HeaderText = "Часы";
            columnTotalHours.Name = "columnTotalHours";
            //
            // columnBaseSalary
            //
            columnBaseSalary.DataPropertyName = "BaseSalary";
            columnBaseSalary.DefaultCellStyle.Format = "N2";
            columnBaseSalary.HeaderText = "Основная оплата";
            columnBaseSalary.Name = "columnBaseSalary";
            //
            // columnBonusAmount
            //
            columnBonusAmount.DataPropertyName = "BonusAmount";
            columnBonusAmount.DefaultCellStyle.Format = "N2";
            columnBonusAmount.HeaderText = "Надбавки";
            columnBonusAmount.Name = "columnBonusAmount";
            //
            // columnTotalSalary
            //
            columnTotalSalary.DataPropertyName = "TotalSalary";
            columnTotalSalary.DefaultCellStyle.Format = "N2";
            columnTotalSalary.HeaderText = "Итого";
            columnTotalSalary.Name = "columnTotalSalary";
            //
            // buttonAdd
            //
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdd.Location = new Point(729, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(119, 72);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            //
            // FormPayrolls
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 360);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewPayrolls);
            Name = "FormPayrolls";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Начисления зарплаты";
            Load += FormPayrolls_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayrolls).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Таблица начислений зарплаты
        private DataGridView dataGridViewPayrolls;
        // Столбец с кодом работника
        private DataGridViewTextBoxColumn columnEmployeeId;
        // Столбец с месяцем начисления
        private DataGridViewTextBoxColumn columnPeriodMonth;
        // Столбец с количеством отработанных часов
        private DataGridViewTextBoxColumn columnTotalHours;
        // Столбец с основной оплатой
        private DataGridViewTextBoxColumn columnBaseSalary;
        // Столбец с суммой надбавок
        private DataGridViewTextBoxColumn columnBonusAmount;
        // Столбец с итоговой суммой начисления
        private DataGridViewTextBoxColumn columnTotalSalary;
        // Кнопка добавления начисления
        private Button buttonAdd;
    }
}
