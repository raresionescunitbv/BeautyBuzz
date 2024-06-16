namespace BeautyBuzz
{
    partial class SendPass
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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendPass));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            codeForgetPass = new Guna.UI2.WinForms.Guna2Button();
            button1SendForgetPass = new Guna.UI2.WinForms.Guna2Button();
            textBoxCodResetPass = new Guna.UI2.WinForms.Guna2TextBox();
            textResetPass = new Guna.UI2.WinForms.Guna2TextBox();
            codprimitForgetPass = new Label();
            mailForgetPass = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // codeForgetPass
            // 
            codeForgetPass.BorderRadius = 10;
            codeForgetPass.Cursor = Cursors.Hand;
            codeForgetPass.CustomizableEdges = customizableEdges1;
            codeForgetPass.DisabledState.BorderColor = Color.DarkGray;
            codeForgetPass.DisabledState.CustomBorderColor = Color.DarkGray;
            codeForgetPass.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            codeForgetPass.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            codeForgetPass.FillColor = Color.DodgerBlue;
            codeForgetPass.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            codeForgetPass.ForeColor = Color.White;
            codeForgetPass.Location = new Point(319, 134);
            codeForgetPass.Margin = new Padding(3, 2, 3, 2);
            codeForgetPass.Name = "codeForgetPass";
            codeForgetPass.ShadowDecoration.CustomizableEdges = customizableEdges2;
            codeForgetPass.Size = new Size(113, 21);
            codeForgetPass.TabIndex = 16;
            codeForgetPass.Text = "Verify code";
            codeForgetPass.Click += codeForgetPass_Click;
            // 
            // button1SendForgetPass
            // 
            button1SendForgetPass.BorderRadius = 10;
            button1SendForgetPass.Cursor = Cursors.Hand;
            button1SendForgetPass.CustomizableEdges = customizableEdges3;
            button1SendForgetPass.DisabledState.BorderColor = Color.DarkGray;
            button1SendForgetPass.DisabledState.CustomBorderColor = Color.DarkGray;
            button1SendForgetPass.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button1SendForgetPass.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button1SendForgetPass.FillColor = Color.DodgerBlue;
            button1SendForgetPass.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button1SendForgetPass.ForeColor = Color.White;
            button1SendForgetPass.Location = new Point(319, 74);
            button1SendForgetPass.Margin = new Padding(3, 2, 3, 2);
            button1SendForgetPass.Name = "button1SendForgetPass";
            button1SendForgetPass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            button1SendForgetPass.Size = new Size(113, 20);
            button1SendForgetPass.TabIndex = 15;
            button1SendForgetPass.Text = "Send";
            button1SendForgetPass.Click += button1SendForgetPass_Click;
            // 
            // textBoxCodResetPass
            // 
            textBoxCodResetPass.BorderRadius = 10;
            textBoxCodResetPass.CustomizableEdges = customizableEdges5;
            textBoxCodResetPass.DefaultText = "";
            textBoxCodResetPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxCodResetPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxCodResetPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxCodResetPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxCodResetPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxCodResetPass.Font = new Font("Segoe UI", 9F);
            textBoxCodResetPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxCodResetPass.Location = new Point(233, 106);
            textBoxCodResetPass.Name = "textBoxCodResetPass";
            textBoxCodResetPass.PasswordChar = '\0';
            textBoxCodResetPass.PlaceholderText = "";
            textBoxCodResetPass.SelectedText = "";
            textBoxCodResetPass.ShadowDecoration.CustomizableEdges = customizableEdges6;
            textBoxCodResetPass.Size = new Size(200, 22);
            textBoxCodResetPass.TabIndex = 14;
            // 
            // textResetPass
            // 
            textResetPass.BorderRadius = 10;
            textResetPass.CustomizableEdges = customizableEdges7;
            textResetPass.DefaultText = "";
            textResetPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textResetPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textResetPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textResetPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textResetPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textResetPass.Font = new Font("Segoe UI", 9F);
            textResetPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textResetPass.Location = new Point(233, 47);
            textResetPass.Name = "textResetPass";
            textResetPass.PasswordChar = '\0';
            textResetPass.PlaceholderText = "";
            textResetPass.SelectedText = "";
            textResetPass.ShadowDecoration.CustomizableEdges = customizableEdges8;
            textResetPass.Size = new Size(200, 22);
            textResetPass.TabIndex = 13;
            // 
            // codprimitForgetPass
            // 
            codprimitForgetPass.AutoSize = true;
            codprimitForgetPass.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            codprimitForgetPass.ForeColor = Color.DodgerBlue;
            codprimitForgetPass.Location = new Point(149, 111);
            codprimitForgetPass.Name = "codprimitForgetPass";
            codprimitForgetPass.Size = new Size(76, 16);
            codprimitForgetPass.TabIndex = 12;
            codprimitForgetPass.Text = "codul primit";
            // 
            // mailForgetPass
            // 
            mailForgetPass.AutoSize = true;
            mailForgetPass.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mailForgetPass.ForeColor = Color.DodgerBlue;
            mailForgetPass.Location = new Point(50, 52);
            mailForgetPass.Name = "mailForgetPass";
            mailForgetPass.Size = new Size(162, 16);
            mailForgetPass.TabIndex = 11;
            mailForgetPass.Text = "Introduceti Adresa de mail";
            // 
            // SendPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 204);
            Controls.Add(pictureBox1);
            Controls.Add(codeForgetPass);
            Controls.Add(button1SendForgetPass);
            Controls.Add(textBoxCodResetPass);
            Controls.Add(textResetPass);
            Controls.Add(codprimitForgetPass);
            Controls.Add(mailForgetPass);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SendPass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SendPass";
            Load += SendPass_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
=======
            mailForgetPass = new Label();
            textResetPass = new TextBox();
            textBoxCodResetPass = new TextBox();
            codprimitForgetPass = new Label();
            button1SendForgetPass = new Button();
            codeForgetPass = new Button();
            SuspendLayout();
            // 
            // mailForgetPass
            // 
            mailForgetPass.AutoSize = true;
            mailForgetPass.Location = new Point(75, 109);
            mailForgetPass.Name = "mailForgetPass";
            mailForgetPass.Size = new Size(185, 20);
            mailForgetPass.TabIndex = 0;
            mailForgetPass.Text = "Introduceti Adresa de mail";
            // 
            // textResetPass
            // 
            textResetPass.Location = new Point(266, 106);
            textResetPass.Name = "textResetPass";
            textResetPass.Size = new Size(228, 27);
            textResetPass.TabIndex = 1;
            // 
            // textBoxCodResetPass
            // 
            textBoxCodResetPass.Location = new Point(266, 185);
            textBoxCodResetPass.Name = "textBoxCodResetPass";
            textBoxCodResetPass.Size = new Size(228, 27);
            textBoxCodResetPass.TabIndex = 2;
            // 
            // codprimitForgetPass
            // 
            codprimitForgetPass.AutoSize = true;
            codprimitForgetPass.Location = new Point(170, 188);
            codprimitForgetPass.Name = "codprimitForgetPass";
            codprimitForgetPass.Size = new Size(90, 20);
            codprimitForgetPass.TabIndex = 3;
            codprimitForgetPass.Text = "codul primit";
            // 
            // button1SendForgetPass
            // 
            button1SendForgetPass.Location = new Point(400, 139);
            button1SendForgetPass.Name = "button1SendForgetPass";
            button1SendForgetPass.Size = new Size(94, 29);
            button1SendForgetPass.TabIndex = 4;
            button1SendForgetPass.Text = "send";
            button1SendForgetPass.UseVisualStyleBackColor = true;
            button1SendForgetPass.Click += button1SendForgetPass_Click;
            // 
            // codeForgetPass
            // 
            codeForgetPass.Location = new Point(400, 218);
            codeForgetPass.Name = "codeForgetPass";
            codeForgetPass.Size = new Size(94, 29);
            codeForgetPass.TabIndex = 5;
            codeForgetPass.Text = "verify code";
            codeForgetPass.UseVisualStyleBackColor = true;
            codeForgetPass.Click += codeForgetPass_Click;
            // 
            // SendPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 323);
            Controls.Add(codeForgetPass);
            Controls.Add(button1SendForgetPass);
            Controls.Add(codprimitForgetPass);
            Controls.Add(textBoxCodResetPass);
            Controls.Add(textResetPass);
            Controls.Add(mailForgetPass);
            Name = "SendPass";
            Text = "SendPass";
            Load += SendPass_Load;
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

<<<<<<< HEAD
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button codeForgetPass;
        private Guna.UI2.WinForms.Guna2Button button1SendForgetPass;
        private Guna.UI2.WinForms.Guna2TextBox textBoxCodResetPass;
        private Guna.UI2.WinForms.Guna2TextBox textResetPass;
        private Label codprimitForgetPass;
        private Label mailForgetPass;
=======
        private Label mailForgetPass;
        private TextBox textResetPass;
        private TextBox textBoxCodResetPass;
        private Label codprimitForgetPass;
        private Button button1SendForgetPass;
        private Button codeForgetPass;
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
    }
}