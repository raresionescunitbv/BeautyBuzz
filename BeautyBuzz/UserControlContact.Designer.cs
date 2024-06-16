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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelControl2 = new Panel();
            btn_control_detalii = new Guna.UI2.WinForms.Guna2Button();
            btn_control_echipa = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // panelControl2
            // 
            panelControl2.Location = new Point(0, 144);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(850, 523);
            panelControl2.TabIndex = 0;
            // 
            // btn_control_detalii
            // 
            btn_control_detalii.BorderColor = Color.Transparent;
            btn_control_detalii.BorderRadius = 10;
            btn_control_detalii.BorderThickness = 3;
            btn_control_detalii.CustomizableEdges = customizableEdges1;
            btn_control_detalii.DisabledState.BorderColor = Color.DarkGray;
            btn_control_detalii.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_control_detalii.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_control_detalii.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_control_detalii.FillColor = Color.DodgerBlue;
            btn_control_detalii.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btn_control_detalii.ForeColor = Color.White;
            btn_control_detalii.Location = new Point(423, 76);
            btn_control_detalii.Name = "btn_control_detalii";
            btn_control_detalii.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_control_detalii.Size = new Size(180, 45);
            btn_control_detalii.TabIndex = 3;
            btn_control_detalii.Text = "Suport tehnic";
            btn_control_detalii.Click += btn_control_detalii_Click;
            // 
            // btn_control_echipa
            // 
            btn_control_echipa.BorderColor = Color.Transparent;
            btn_control_echipa.BorderRadius = 10;
            btn_control_echipa.BorderThickness = 3;
            btn_control_echipa.CustomizableEdges = customizableEdges3;
            btn_control_echipa.DisabledState.BorderColor = Color.DarkGray;
            btn_control_echipa.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_control_echipa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_control_echipa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_control_echipa.FillColor = Color.DodgerBlue;
            btn_control_echipa.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btn_control_echipa.ForeColor = Color.White;
            btn_control_echipa.Location = new Point(190, 76);
            btn_control_echipa.Name = "btn_control_echipa";
            btn_control_echipa.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_control_echipa.Size = new Size(180, 45);
            btn_control_echipa.TabIndex = 2;
            btn_control_echipa.Text = "Vino in echipa BeautyBuzz";
            btn_control_echipa.Click += btn_control_echipa_Click;
            // 
            // UserControlContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_control_detalii);
            Controls.Add(btn_control_echipa);
            Controls.Add(panelControl2);
            Name = "UserControlContact";
            Size = new Size(850, 667);
            Load += UserControlContact_Load;
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_control_detalii;
        private Guna.UI2.WinForms.Guna2Button btn_control_echipa;
        public Panel panelControl2;
    }
}
