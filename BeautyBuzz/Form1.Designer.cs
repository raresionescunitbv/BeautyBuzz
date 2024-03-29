namespace BeautyBuzz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textCreateAc1 = new TextBox();
            label1 = new Label();
            CreateAcName = new Label();
            FirstNameCreateAc = new Label();
            textBoxCreateAc2 = new TextBox();
            checkBox1 = new CheckBox();
            PhoneNumber = new Label();
            Email = new Label();
            checkBox2 = new CheckBox();
            or = new Label();
            textBox1 = new TextBox();
            Password = new Label();
            ConfirmPassword = new Label();
            textBox2 = new TextBox();
            SignUp = new Button();
            showPass = new CheckBox();
            textBoxInput = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textCreateAc1
            // 
            textCreateAc1.Location = new Point(680, 135);
            textCreateAc1.Margin = new Padding(3, 2, 3, 2);
            textCreateAc1.Name = "textCreateAc1";
            textCreateAc1.Size = new Size(213, 22);
            textCreateAc1.TabIndex = 0;
            textCreateAc1.TextChanged += textBox1_TextChanged;
            textCreateAc1.KeyDown += textCreateAc1_KeyDown;
            textCreateAc1.KeyPress += textCreateAc1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(674, 80);
            label1.Name = "label1";
            label1.Size = new Size(217, 38);
            label1.TabIndex = 1;
            label1.Text = "Create Account";
            // 
            // CreateAcName
            // 
            CreateAcName.AutoSize = true;
            CreateAcName.FlatStyle = FlatStyle.Flat;
            CreateAcName.Location = new Point(557, 138);
            CreateAcName.Margin = new Padding(5, 0, 5, 0);
            CreateAcName.Name = "CreateAcName";
            CreateAcName.Size = new Size(100, 16);
            CreateAcName.TabIndex = 3;
            CreateAcName.Text = "Your LastName";
            // 
            // FirstNameCreateAc
            // 
            FirstNameCreateAc.AutoSize = true;
            FirstNameCreateAc.Location = new Point(557, 195);
            FirstNameCreateAc.Margin = new Padding(5, 0, 5, 0);
            FirstNameCreateAc.Name = "FirstNameCreateAc";
            FirstNameCreateAc.Size = new Size(100, 16);
            FirstNameCreateAc.TabIndex = 5;
            FirstNameCreateAc.Text = "Your FirstName";
            // 
            // textBoxCreateAc2
            // 
            textBoxCreateAc2.Location = new Point(680, 192);
            textBoxCreateAc2.Margin = new Padding(3, 2, 3, 2);
            textBoxCreateAc2.Name = "textBoxCreateAc2";
            textBoxCreateAc2.Size = new Size(213, 22);
            textBoxCreateAc2.TabIndex = 1;
            textBoxCreateAc2.KeyDown += textBoxCreateAc2_KeyDown;
            textBoxCreateAc2.KeyPress += textBoxCreateAc2_KeyPress;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(654, 239);
            checkBox1.Margin = new Padding(5, 4, 5, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 2;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox_CheckedChanged;
            checkBox1.KeyDown += checkBox1_KeyDown;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Location = new Point(676, 239);
            PhoneNumber.Margin = new Padding(5, 0, 5, 0);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(97, 16);
            PhoneNumber.TabIndex = 2;
            PhoneNumber.Text = "Phone Number";
            PhoneNumber.Click += label2_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(853, 239);
            Email.Margin = new Padding(5, 0, 5, 0);
            Email.Name = "Email";
            Email.Size = new Size(41, 16);
            Email.TabIndex = 8;
            Email.Text = "Email";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Cursor = Cursors.Hand;
            checkBox2.Location = new Point(824, 239);
            checkBox2.Margin = new Padding(5, 4, 5, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 3;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox_CheckedChanged;
            checkBox2.KeyDown += checkBox2_KeyDown;
            // 
            // or
            // 
            or.AutoSize = true;
            or.Location = new Point(783, 239);
            or.Margin = new Padding(5, 0, 5, 0);
            or.Name = "or";
            or.Size = new Size(19, 16);
            or.TabIndex = 10;
            or.Text = "or";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(680, 396);
            textBox1.Margin = new Padding(5, 4, 5, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 22);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged_1;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(557, 399);
            Password.Margin = new Padding(5, 0, 5, 0);
            Password.Name = "Password";
            Password.Size = new Size(67, 16);
            Password.TabIndex = 14;
            Password.Text = "Password";
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.AutoSize = true;
            ConfirmPassword.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmPassword.Location = new Point(557, 443);
            ConfirmPassword.Margin = new Padding(5, 0, 5, 0);
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.Size = new Size(115, 16);
            ConfirmPassword.TabIndex = 16;
            ConfirmPassword.Text = "Confirm Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(680, 437);
            textBox2.Margin = new Padding(5, 4, 5, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 22);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // SignUp
            // 
            SignUp.Cursor = Cursors.Hand;
            SignUp.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            SignUp.ForeColor = Color.DodgerBlue;
            SignUp.Location = new Point(747, 486);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(75, 34);
            SignUp.TabIndex = 8;
            SignUp.Text = "Sign Up";
            SignUp.UseVisualStyleBackColor = true;
            SignUp.Click += SignUp_Click;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Cursor = Cursors.Hand;
            showPass.Location = new Point(921, 396);
            showPass.Name = "showPass";
            showPass.Size = new Size(125, 20);
            showPass.TabIndex = 6;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += showPass_CheckedChanged;
            showPass.KeyDown += showPass_KeyDown;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(678, 307);
            textBoxInput.Margin = new Padding(3, 2, 3, 2);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(213, 22);
            textBoxInput.TabIndex = 4;
            textBoxInput.KeyDown += textInput_KeyDown;
            textBoxInput.KeyPress += textBoxInput_KeyPress;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(747, 541);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 17;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 665);
            Controls.Add(button1);
            Controls.Add(textBoxInput);
            Controls.Add(showPass);
            Controls.Add(SignUp);
            Controls.Add(ConfirmPassword);
            Controls.Add(textBox2);
            Controls.Add(Password);
            Controls.Add(textBox1);
            Controls.Add(or);
            Controls.Add(checkBox2);
            Controls.Add(Email);
            Controls.Add(PhoneNumber);
            Controls.Add(checkBox1);
            Controls.Add(FirstNameCreateAc);
            Controls.Add(textBoxCreateAc2);
            Controls.Add(CreateAcName);
            Controls.Add(label1);
            Controls.Add(textCreateAc1);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BeautyBuzz";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CreateAcName;
        private System.Windows.Forms.Label FirstNameCreateAc;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label or;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label ConfirmPassword;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.Label label2;
        private Button button1;
        public TextBox textCreateAc1;
        public TextBox textBoxCreateAc2;
        public TextBox textBoxInput;
        public TextBox textBox1;
        public TextBox textBox2;
    }
}

