namespace BeautyBuzz
{
    partial class SmsVerificationApp
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmsVerificationApp));
            ConfirmationButtonNumber = new Guna.UI2.WinForms.Guna2Button();
            ConfirmCodeNumber = new Guna.UI2.WinForms.Guna2TextBox();
            VerificationButtonNumber = new Guna.UI2.WinForms.Guna2Button();
            VerificationCodeNumber = new Guna.UI2.WinForms.Guna2TextBox();
            ConfirmationCodeNumber = new Label();
            labelVfNumar = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ConfirmationButtonNumber
            // 
            ConfirmationButtonNumber.BorderRadius = 10;
            ConfirmationButtonNumber.CustomizableEdges = customizableEdges1;
            ConfirmationButtonNumber.DisabledState.BorderColor = Color.DarkGray;
            ConfirmationButtonNumber.DisabledState.CustomBorderColor = Color.DarkGray;
            ConfirmationButtonNumber.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ConfirmationButtonNumber.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ConfirmationButtonNumber.FillColor = Color.DodgerBlue;
            ConfirmationButtonNumber.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            ConfirmationButtonNumber.ForeColor = Color.White;
            ConfirmationButtonNumber.Location = new Point(349, 139);
            ConfirmationButtonNumber.Margin = new Padding(3, 2, 3, 2);
            ConfirmationButtonNumber.Name = "ConfirmationButtonNumber";
            ConfirmationButtonNumber.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ConfirmationButtonNumber.Size = new Size(81, 22);
            ConfirmationButtonNumber.TabIndex = 21;
            ConfirmationButtonNumber.Text = "Confirm";
            ConfirmationButtonNumber.Click += ConfirmationButtonNumber_Click;
            // 
            // ConfirmCodeNumber
            // 
            ConfirmCodeNumber.BorderRadius = 10;
            ConfirmCodeNumber.CustomizableEdges = customizableEdges3;
            ConfirmCodeNumber.DefaultText = "";
            ConfirmCodeNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            ConfirmCodeNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            ConfirmCodeNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            ConfirmCodeNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            ConfirmCodeNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ConfirmCodeNumber.Font = new Font("Segoe UI", 9F);
            ConfirmCodeNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            ConfirmCodeNumber.Location = new Point(261, 117);
            ConfirmCodeNumber.Name = "ConfirmCodeNumber";
            ConfirmCodeNumber.PasswordChar = '\0';
            ConfirmCodeNumber.PlaceholderText = "";
            ConfirmCodeNumber.SelectedText = "";
            ConfirmCodeNumber.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ConfirmCodeNumber.Size = new Size(170, 17);
            ConfirmCodeNumber.TabIndex = 20;
            // 
            // VerificationButtonNumber
            // 
            VerificationButtonNumber.BorderRadius = 10;
            VerificationButtonNumber.CustomizableEdges = customizableEdges5;
            VerificationButtonNumber.DisabledState.BorderColor = Color.DarkGray;
            VerificationButtonNumber.DisabledState.CustomBorderColor = Color.DarkGray;
            VerificationButtonNumber.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            VerificationButtonNumber.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            VerificationButtonNumber.FillColor = Color.DodgerBlue;
            VerificationButtonNumber.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            VerificationButtonNumber.ForeColor = Color.White;
            VerificationButtonNumber.Location = new Point(349, 66);
            VerificationButtonNumber.Margin = new Padding(3, 2, 3, 2);
            VerificationButtonNumber.Name = "VerificationButtonNumber";
            VerificationButtonNumber.ShadowDecoration.CustomizableEdges = customizableEdges6;
            VerificationButtonNumber.Size = new Size(81, 23);
            VerificationButtonNumber.TabIndex = 19;
            VerificationButtonNumber.Text = "Send";
            VerificationButtonNumber.Click += VerificationButtonNumber_Click;
            // 
            // VerificationCodeNumber
            // 
            VerificationCodeNumber.BorderRadius = 10;
            VerificationCodeNumber.CustomizableEdges = customizableEdges7;
            VerificationCodeNumber.DefaultText = "";
            VerificationCodeNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            VerificationCodeNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            VerificationCodeNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            VerificationCodeNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            VerificationCodeNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            VerificationCodeNumber.Font = new Font("Segoe UI", 9F);
            VerificationCodeNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            VerificationCodeNumber.Location = new Point(261, 44);
            VerificationCodeNumber.Name = "VerificationCodeNumber";
            VerificationCodeNumber.PasswordChar = '\0';
            VerificationCodeNumber.PlaceholderText = "";
            VerificationCodeNumber.SelectedText = "";
            VerificationCodeNumber.ShadowDecoration.CustomizableEdges = customizableEdges8;
            VerificationCodeNumber.Size = new Size(170, 17);
            VerificationCodeNumber.TabIndex = 18;
            // 
            // ConfirmationCodeNumber
            // 
            ConfirmationCodeNumber.AutoSize = true;
            ConfirmationCodeNumber.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmationCodeNumber.ForeColor = Color.DodgerBlue;
            ConfirmationCodeNumber.Location = new Point(141, 120);
            ConfirmationCodeNumber.Name = "ConfirmationCodeNumber";
            ConfirmationCodeNumber.Size = new Size(103, 16);
            ConfirmationCodeNumber.TabIndex = 17;
            ConfirmationCodeNumber.Text = "Confirmati codul";
            // 
            // labelVfNumar
            // 
            labelVfNumar.AutoSize = true;
            labelVfNumar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVfNumar.ForeColor = Color.DodgerBlue;
            labelVfNumar.Location = new Point(107, 44);
            labelVfNumar.Name = "labelVfNumar";
            labelVfNumar.Size = new Size(134, 16);
            labelVfNumar.TabIndex = 16;
            labelVfNumar.Text = "Reintroduceti numarul";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 30);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SmsVerificationApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 194);
            Controls.Add(pictureBox1);
            Controls.Add(ConfirmationButtonNumber);
            Controls.Add(ConfirmCodeNumber);
            Controls.Add(VerificationButtonNumber);
            Controls.Add(VerificationCodeNumber);
            Controls.Add(ConfirmationCodeNumber);
            Controls.Add(labelVfNumar);
            Name = "SmsVerificationApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SmsVerificationApp";
            Load += SmsVerificationApp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ConfirmationButtonNumber;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmCodeNumber;
        private Guna.UI2.WinForms.Guna2Button VerificationButtonNumber;
        private Guna.UI2.WinForms.Guna2TextBox VerificationCodeNumber;
        private Label ConfirmationCodeNumber;
        private Label labelVfNumar;
        private PictureBox pictureBox1;
    }
}