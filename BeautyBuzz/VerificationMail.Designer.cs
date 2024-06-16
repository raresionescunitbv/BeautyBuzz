namespace BeautyBuzz
{
    partial class VerificationMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificationMail));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            ConfirmationButton = new Guna.UI2.WinForms.Guna2Button();
            ConfirmCode = new Guna.UI2.WinForms.Guna2TextBox();
            VerificationButton = new Guna.UI2.WinForms.Guna2Button();
            VerificationCode = new Guna.UI2.WinForms.Guna2TextBox();
            ConfirmationCode = new Label();
            CodVerificare = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 27);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // ConfirmationButton
            // 
            ConfirmationButton.BorderRadius = 10;
            ConfirmationButton.Cursor = Cursors.Hand;
            ConfirmationButton.CustomizableEdges = customizableEdges1;
            ConfirmationButton.DisabledState.BorderColor = Color.DarkGray;
            ConfirmationButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ConfirmationButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ConfirmationButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ConfirmationButton.FillColor = Color.DodgerBlue;
            ConfirmationButton.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            ConfirmationButton.ForeColor = Color.White;
            ConfirmationButton.Location = new Point(285, 149);
            ConfirmationButton.Margin = new Padding(3, 2, 3, 2);
            ConfirmationButton.Name = "ConfirmationButton";
            ConfirmationButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ConfirmationButton.Size = new Size(96, 20);
            ConfirmationButton.TabIndex = 16;
            ConfirmationButton.Text = "Confirm Code";
            ConfirmationButton.Click += ConfirmationButton_Click;
            // 
            // ConfirmCode
            // 
            ConfirmCode.BorderRadius = 10;
            ConfirmCode.CustomizableEdges = customizableEdges3;
            ConfirmCode.DefaultText = "";
            ConfirmCode.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            ConfirmCode.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            ConfirmCode.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            ConfirmCode.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            ConfirmCode.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ConfirmCode.Font = new Font("Segoe UI", 9F);
            ConfirmCode.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            ConfirmCode.Location = new Point(211, 125);
            ConfirmCode.Name = "ConfirmCode";
            ConfirmCode.PasswordChar = '\0';
            ConfirmCode.PlaceholderText = "";
            ConfirmCode.SelectedText = "";
            ConfirmCode.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ConfirmCode.Size = new Size(170, 18);
            ConfirmCode.TabIndex = 15;
            // 
            // VerificationButton
            // 
            VerificationButton.BorderRadius = 10;
            VerificationButton.Cursor = Cursors.Hand;
            VerificationButton.CustomizableEdges = customizableEdges5;
            VerificationButton.DisabledState.BorderColor = Color.DarkGray;
            VerificationButton.DisabledState.CustomBorderColor = Color.DarkGray;
            VerificationButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            VerificationButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            VerificationButton.FillColor = Color.DodgerBlue;
            VerificationButton.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            VerificationButton.ForeColor = Color.White;
            VerificationButton.Location = new Point(285, 78);
            VerificationButton.Margin = new Padding(3, 2, 3, 2);
            VerificationButton.Name = "VerificationButton";
            VerificationButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            VerificationButton.Size = new Size(96, 23);
            VerificationButton.TabIndex = 14;
            VerificationButton.Text = "Send Code";
            VerificationButton.Click += VerificationButton_Click;
            // 
            // VerificationCode
            // 
            VerificationCode.BorderRadius = 10;
            VerificationCode.CustomizableEdges = customizableEdges7;
            VerificationCode.DefaultText = "";
            VerificationCode.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            VerificationCode.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            VerificationCode.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            VerificationCode.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            VerificationCode.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            VerificationCode.Font = new Font("Segoe UI", 9F);
            VerificationCode.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            VerificationCode.Location = new Point(211, 55);
            VerificationCode.Name = "VerificationCode";
            VerificationCode.PasswordChar = '\0';
            VerificationCode.PlaceholderText = "";
            VerificationCode.SelectedText = "";
            VerificationCode.ShadowDecoration.CustomizableEdges = customizableEdges8;
            VerificationCode.Size = new Size(170, 18);
            VerificationCode.TabIndex = 13;
            // 
            // ConfirmationCode
            // 
            ConfirmationCode.AutoSize = true;
            ConfirmationCode.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmationCode.ForeColor = Color.DodgerBlue;
            ConfirmationCode.Location = new Point(91, 125);
            ConfirmationCode.Name = "ConfirmationCode";
            ConfirmationCode.Size = new Size(103, 16);
            ConfirmationCode.TabIndex = 12;
            ConfirmationCode.Text = "Confirmati codul";
            // 
            // CodVerificare
            // 
            CodVerificare.AutoSize = true;
            CodVerificare.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CodVerificare.ForeColor = Color.DodgerBlue;
            CodVerificare.Location = new Point(12, 55);
            CodVerificare.Name = "CodVerificare";
            CodVerificare.Size = new Size(175, 16);
            CodVerificare.TabIndex = 11;
            CodVerificare.Text = "Reintroduceti adresa de mail";
            // 
            // VerificationMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 192);
            Controls.Add(pictureBox1);
            Controls.Add(ConfirmationButton);
            Controls.Add(ConfirmCode);
            Controls.Add(VerificationButton);
            Controls.Add(VerificationCode);
            Controls.Add(ConfirmationCode);
            Controls.Add(CodVerificare);
            Name = "VerificationMail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerificationMail";
            Load += VerificationMail_Load;
            Click += pictureBox1_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button ConfirmationButton;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmCode;
        private Guna.UI2.WinForms.Guna2Button VerificationButton;
        private Guna.UI2.WinForms.Guna2TextBox VerificationCode;
        private Label ConfirmationCode;
        private Label CodVerificare;
    }
}