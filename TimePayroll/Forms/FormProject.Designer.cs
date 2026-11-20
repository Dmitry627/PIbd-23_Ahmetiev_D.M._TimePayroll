namespace TimePayroll.Forms
{
    // Разметка и элементы формы проекта
    partial class FormProject
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
            labelProjectName = new Label();
            labelProjectType = new Label();
            labelManager = new Label();
            labelDeveloper = new Label();
            textBoxProjectName = new TextBox();
            comboBoxProjectType = new ComboBox();
            comboBoxManager = new ComboBox();
            comboBoxDeveloper = new ComboBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            //
            // labelProjectName
            //
            labelProjectName.AutoSize = true;
            labelProjectName.Location = new Point(28, 32);
            labelProjectName.Name = "labelProjectName";
            labelProjectName.Size = new Size(106, 15);
            labelProjectName.TabIndex = 0;
            labelProjectName.Text = "Название проекта";
            //
            // labelProjectType
            //
            labelProjectType.AutoSize = true;
            labelProjectType.Location = new Point(28, 72);
            labelProjectType.Name = "labelProjectType";
            labelProjectType.Size = new Size(75, 15);
            labelProjectType.TabIndex = 2;
            labelProjectType.Text = "Тип проекта";
            //
            // labelManager
            //
            labelManager.AutoSize = true;
            labelManager.Location = new Point(28, 112);
            labelManager.Name = "labelManager";
            labelManager.Size = new Size(65, 15);
            labelManager.TabIndex = 4;
            labelManager.Text = "Менеджер";
            //
            // labelDeveloper
            //
            labelDeveloper.AutoSize = true;
            labelDeveloper.Location = new Point(28, 152);
            labelDeveloper.Name = "labelDeveloper";
            labelDeveloper.Size = new Size(77, 15);
            labelDeveloper.TabIndex = 6;
            labelDeveloper.Text = "Разработчик";
            //
            // textBoxProjectName
            //
            textBoxProjectName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxProjectName.Location = new Point(166, 29);
            textBoxProjectName.Name = "textBoxProjectName";
            textBoxProjectName.Size = new Size(226, 23);
            textBoxProjectName.TabIndex = 1;
            //
            // comboBoxProjectType
            //
            comboBoxProjectType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxProjectType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProjectType.FormattingEnabled = true;
            comboBoxProjectType.Location = new Point(166, 69);
            comboBoxProjectType.Name = "comboBoxProjectType";
            comboBoxProjectType.Size = new Size(226, 23);
            comboBoxProjectType.TabIndex = 3;
            //
            // comboBoxManager
            //
            comboBoxManager.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxManager.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxManager.FormattingEnabled = true;
            comboBoxManager.Location = new Point(166, 109);
            comboBoxManager.Name = "comboBoxManager";
            comboBoxManager.Size = new Size(226, 23);
            comboBoxManager.TabIndex = 5;
            //
            // comboBoxDeveloper
            //
            comboBoxDeveloper.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxDeveloper.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDeveloper.FormattingEnabled = true;
            comboBoxDeveloper.Location = new Point(166, 149);
            comboBoxDeveloper.Name = "comboBoxDeveloper";
            comboBoxDeveloper.Size = new Size(226, 23);
            comboBoxDeveloper.TabIndex = 7;
            //
            // buttonSave
            //
            buttonSave.Location = new Point(106, 201);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(90, 26);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            //
            // buttonCancel
            //
            buttonCancel.Location = new Point(224, 201);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(90, 26);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            //
            // FormProject
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 254);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxDeveloper);
            Controls.Add(comboBoxManager);
            Controls.Add(comboBoxProjectType);
            Controls.Add(textBoxProjectName);
            Controls.Add(labelDeveloper);
            Controls.Add(labelManager);
            Controls.Add(labelProjectType);
            Controls.Add(labelProjectName);
            Name = "FormProject";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Проект";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Хранит подпись поля названия проекта
        private Label labelProjectName;
        // Хранит подпись списка типов проекта
        private Label labelProjectType;
        // Хранит подпись списка менеджеров
        private Label labelManager;
        // Хранит подпись списка разработчиков
        private Label labelDeveloper;
        // Хранит поле ввода названия проекта
        private TextBox textBoxProjectName;
        // Хранит список типов проекта
        private ComboBox comboBoxProjectType;
        // Хранит список менеджеров
        private ComboBox comboBoxManager;
        // Хранит список разработчиков
        private ComboBox comboBoxDeveloper;
        // Хранит кнопку сохранения записи
        private Button buttonSave;
        // Хранит кнопку отмены ввода
        private Button buttonCancel;
    }
}
