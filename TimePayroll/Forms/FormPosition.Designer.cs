namespace TimePayroll.Forms
{
    partial class FormPosition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBoxPositionName = new TextBox();
            LabelPosition = new Label();
            LabelHourlyRate = new Label();
            NumericUpDownHourlyRate = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownHourlyRate).BeginInit();
            SuspendLayout();
            // 
            // TextBoxPositionName
            // 
            TextBoxPositionName.Location = new Point(175, 47);
            TextBoxPositionName.Name = "TextBoxPositionName";
            TextBoxPositionName.Size = new Size(164, 23);
            TextBoxPositionName.TabIndex = 0;
            // 
            // LabelPosition
            // 
            LabelPosition.AutoSize = true;
            LabelPosition.Location = new Point(35, 50);
            LabelPosition.Name = "LabelPosition";
            LabelPosition.Size = new Size(69, 15);
            LabelPosition.TabIndex = 1;
            LabelPosition.Text = "Должность";
            // 
            // LabelHourlyRate
            // 
            LabelHourlyRate.AutoSize = true;
            LabelHourlyRate.Location = new Point(35, 108);
            LabelHourlyRate.Name = "LabelHourlyRate";
            LabelHourlyRate.Size = new Size(105, 15);
            LabelHourlyRate.TabIndex = 2;
            LabelHourlyRate.Text = "Почасовая ставка";
            // 
            // NumericUpDownHourlyRate
            // 
            NumericUpDownHourlyRate.DecimalPlaces = 2;
            NumericUpDownHourlyRate.Location = new Point(175, 106);
            NumericUpDownHourlyRate.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NumericUpDownHourlyRate.Name = "NumericUpDownHourlyRate";
            NumericUpDownHourlyRate.Size = new Size(120, 23);
            NumericUpDownHourlyRate.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(65, 197);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(220, 197);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormPosition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 250);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(NumericUpDownHourlyRate);
            Controls.Add(LabelHourlyRate);
            Controls.Add(LabelPosition);
            Controls.Add(TextBoxPositionName);
            Name = "FormPosition";
            Text = "Должность";
            ((System.ComponentModel.ISupportInitialize)NumericUpDownHourlyRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxPositionName;
        private Label LabelPosition;
        private Label LabelHourlyRate;
        private NumericUpDown NumericUpDownHourlyRate;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
