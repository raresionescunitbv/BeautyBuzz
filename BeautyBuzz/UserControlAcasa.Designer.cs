namespace BeautyBuzz
{
    partial class UserControlAcasa
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
            comboBoxOrase = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxOrase
            // 
            comboBoxOrase.FormattingEnabled = true;
            comboBoxOrase.Items.AddRange(new object[] { "Brasov", "Bucuresti" });
            comboBoxOrase.Location = new Point(340, 51);
            comboBoxOrase.Name = "comboBoxOrase";
            comboBoxOrase.Size = new Size(121, 23);
            comboBoxOrase.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(79, 222);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(706, 150);
            dataGridView1.TabIndex = 1;
            // 
            // UserControlAcasa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxOrase);
            Name = "UserControlAcasa";
            Size = new Size(850, 667);
            Load += UserControlAcasa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxOrase;
        private DataGridView dataGridView1;
    }
}
