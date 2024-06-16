namespace BeautyBuzz
{
    partial class ResetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPass));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            submitNewPass = new Guna.UI2.WinForms.Guna2Button();
            textBoxConfirmNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            textBoxNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            ConfirmNewPass = new Label();
            NewResetPass = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 32);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // guna2CheckBox1
            // 
            guna2CheckBox1.AutoSize = true;
            guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.CheckedState.BorderRadius = 0;
            guna2CheckBox1.CheckedState.BorderThickness = 0;
            guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.Cursor = Cursors.Hand;
            guna2CheckBox1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2CheckBox1.ForeColor = Color.DodgerBlue;
            guna2CheckBox1.Location = new Point(337, 59);
            guna2CheckBox1.Margin = new Padding(3, 2, 3, 2);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(116, 20);
            guna2CheckBox1.TabIndex = 15;
            guna2CheckBox1.Text = "Show password";
            guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox1.UncheckedState.BorderRadius = 0;
            guna2CheckBox1.UncheckedState.BorderThickness = 0;
            guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox1.CheckedChanged += guna2CheckBox1_CheckedChanged;
            // 
            // submitNewPass
            // 
            submitNewPass.BorderRadius = 10;
            submitNewPass.Cursor = Cursors.Hand;
            submitNewPass.CustomizableEdges = customizableEdges1;
            submitNewPass.DisabledState.BorderColor = Color.DarkGray;
            submitNewPass.DisabledState.CustomBorderColor = Color.DarkGray;
            submitNewPass.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            submitNewPass.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            submitNewPass.FillColor = Color.DodgerBlue;
            submitNewPass.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            submitNewPass.ForeColor = Color.White;
            submitNewPass.Location = new Point(255, 142);
            submitNewPass.Margin = new Padding(3, 2, 3, 2);
            submitNewPass.Name = "submitNewPass";
            submitNewPass.ShadowDecoration.CustomizableEdges = customizableEdges2;
            submitNewPass.Size = new Size(77, 22);
            submitNewPass.TabIndex = 14;
            submitNewPass.Text = "Submit";
            submitNewPass.Click += submitNewPass_Click;
            // 
            // textBoxConfirmNewPass
            // 
            textBoxConfirmNewPass.BorderRadius = 10;
            textBoxConfirmNewPass.CustomizableEdges = customizableEdges3;
            textBoxConfirmNewPass.DefaultText = "";
            textBoxConfirmNewPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxConfirmNewPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxConfirmNewPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxConfirmNewPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxConfirmNewPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxConfirmNewPass.Font = new Font("Segoe UI", 9F);
            textBoxConfirmNewPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxConfirmNewPass.Location = new Point(136, 107);
            textBoxConfirmNewPass.Name = "textBoxConfirmNewPass";
            textBoxConfirmNewPass.PasswordChar = '\0';
            textBoxConfirmNewPass.PlaceholderText = "";
            textBoxConfirmNewPass.SelectedText = "";
            textBoxConfirmNewPass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            textBoxConfirmNewPass.Size = new Size(198, 21);
            textBoxConfirmNewPass.TabIndex = 13;
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.BorderRadius = 10;
            textBoxNewPass.CustomizableEdges = customizableEdges5;
            textBoxNewPass.DefaultText = "";
            textBoxNewPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxNewPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxNewPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxNewPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxNewPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxNewPass.Font = new Font("Segoe UI", 9F);
            textBoxNewPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxNewPass.Location = new Point(134, 56);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.PasswordChar = '\0';
            textBoxNewPass.PlaceholderText = "";
            textBoxNewPass.SelectedText = "";
            textBoxNewPass.ShadowDecoration.CustomizableEdges = customizableEdges6;
            textBoxNewPass.Size = new Size(198, 21);
            textBoxNewPass.TabIndex = 12;
            // 
            // ConfirmNewPass
            // 
            ConfirmNewPass.AutoSize = true;
            ConfirmNewPass.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmNewPass.ForeColor = Color.DodgerBlue;
            ConfirmNewPass.Location = new Point(55, 107);
            ConfirmNewPass.Name = "ConfirmNewPass";
            ConfirmNewPass.Size = new Size(66, 16);
            ConfirmNewPass.TabIndex = 11;
            ConfirmNewPass.Text = "Confirmati";
            // 
            // NewResetPass
            // 
            NewResetPass.AutoSize = true;
            NewResetPass.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewResetPass.ForeColor = Color.DodgerBlue;
            NewResetPass.Location = new Point(42, 56);
            NewResetPass.Name = "NewResetPass";
            NewResetPass.Size = new Size(80, 16);
            NewResetPass.TabIndex = 10;
            NewResetPass.Text = "Noua Parola";
            // 
=======
            NewResetPass = new Label();
            ConfirmNewPass = new Label();
            textBoxNewPass = new TextBox();
            textBoxConfirmNewPass = new TextBox();
            submitNewPass = new Button();
            SuspendLayout();
            // 
            // NewResetPass
            // 
            NewResetPass.AutoSize = true;
            NewResetPass.Location = new Point(75, 44);
            NewResetPass.Name = "NewResetPass";
            NewResetPass.Size = new Size(72, 15);
            NewResetPass.TabIndex = 0;
            NewResetPass.Text = "Noua Parola";
            // 
            // ConfirmNewPass
            // 
            ConfirmNewPass.AutoSize = true;
            ConfirmNewPass.Location = new Point(75, 95);
            ConfirmNewPass.Name = "ConfirmNewPass";
            ConfirmNewPass.Size = new Size(64, 15);
            ConfirmNewPass.TabIndex = 1;
            ConfirmNewPass.Text = "Confirmati";
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.Location = new Point(169, 42);
            textBoxNewPass.Margin = new Padding(3, 2, 3, 2);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.Size = new Size(197, 23);
            textBoxNewPass.TabIndex = 2;
            // 
            // textBoxConfirmNewPass
            // 
            textBoxConfirmNewPass.Location = new Point(169, 93);
            textBoxConfirmNewPass.Margin = new Padding(3, 2, 3, 2);
            textBoxConfirmNewPass.Name = "textBoxConfirmNewPass";
            textBoxConfirmNewPass.Size = new Size(197, 23);
            textBoxConfirmNewPass.TabIndex = 3;
            // 
            // submitNewPass
            // 
            submitNewPass.Location = new Point(284, 130);
            submitNewPass.Margin = new Padding(3, 2, 3, 2);
            submitNewPass.Name = "submitNewPass";
            submitNewPass.Size = new Size(82, 22);
            submitNewPass.TabIndex = 4;
            submitNewPass.Text = "reset";
            submitNewPass.UseVisualStyleBackColor = true;
            submitNewPass.Click += submitNewPass_Click;
            // 
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
            // ResetPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(478, 189);
            Controls.Add(pictureBox1);
            Controls.Add(guna2CheckBox1);
=======
            ClientSize = new Size(460, 198);
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
            Controls.Add(submitNewPass);
            Controls.Add(textBoxConfirmNewPass);
            Controls.Add(textBoxNewPass);
            Controls.Add(ConfirmNewPass);
            Controls.Add(NewResetPass);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ResetPass";
<<<<<<< HEAD
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPass";
            Load += ResetPass_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
=======
            Text = "ResetPass";
            Load += ResetPass_Load;
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

<<<<<<< HEAD
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2Button submitNewPass;
        private Guna.UI2.WinForms.Guna2TextBox textBoxConfirmNewPass;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNewPass;
        private Label ConfirmNewPass;
        private Label NewResetPass;
=======
        private Label NewResetPass;
        private Label ConfirmNewPass;
        private TextBox textBoxNewPass;
        private TextBox textBoxConfirmNewPass;
        private Button submitNewPass;
>>>>>>> 5ab7d3d0119d4a015ec2cdb03a9015950015917f
    }
}