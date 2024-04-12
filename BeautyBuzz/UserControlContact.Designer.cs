namespace BeautyBuzz
{
    partial class UserControlContact
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
            guna2RadialGauge1 = new Guna.UI2.WinForms.Guna2RadialGauge();
            SuspendLayout();
            // 
            // guna2RadialGauge1
            // 
            guna2RadialGauge1.Font = new Font("Verdana", 8.2F);
            guna2RadialGauge1.ForeColor = Color.FromArgb(139, 152, 166);
            guna2RadialGauge1.Location = new Point(300, 220);
            guna2RadialGauge1.MinimumSize = new Size(30, 30);
            guna2RadialGauge1.Name = "guna2RadialGauge1";
            guna2RadialGauge1.Size = new Size(240, 240);
            guna2RadialGauge1.TabIndex = 0;
            // 
            // UserControlContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2RadialGauge1);
            Name = "UserControlContact";
            Size = new Size(850, 667);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2RadialGauge guna2RadialGauge1;
    }
}
