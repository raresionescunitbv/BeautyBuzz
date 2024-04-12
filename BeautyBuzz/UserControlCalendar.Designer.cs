namespace BeautyBuzz
{
    partial class UserControlCalendar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monthCalendar1 = new MonthCalendar();
            comboBoxOre = new ComboBox();
            SaveDataButton = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(249, 103);
            monthCalendar1.Margin = new Padding(10, 12, 10, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // comboBoxOre
            // 
            comboBoxOre.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxOre.FormattingEnabled = true;
            comboBoxOre.Location = new Point(522, 103);
            comboBoxOre.Margin = new Padding(3, 4, 3, 4);
            comboBoxOre.Name = "comboBoxOre";
            comboBoxOre.Size = new Size(138, 28);
            comboBoxOre.TabIndex = 1;
            // 
            // SaveDataButton
            // 
            SaveDataButton.Location = new Point(310, 335);
            SaveDataButton.Margin = new Padding(3, 4, 3, 4);
            SaveDataButton.Name = "SaveDataButton";
            SaveDataButton.Size = new Size(144, 39);
            SaveDataButton.TabIndex = 2;
            SaveDataButton.Text = "Salveaza Data";
            SaveDataButton.UseVisualStyleBackColor = true;
            SaveDataButton.Click += SaveDataButton_Click_1;
            // 
            // UserControlCalendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 521);
            Controls.Add(SaveDataButton);
            Controls.Add(comboBoxOre);
            Controls.Add(monthCalendar1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlCalendar";
            Load += UserControlCalendar_Load;
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private ComboBox comboBoxOre;
        private Button SaveDataButton;
    }
}
