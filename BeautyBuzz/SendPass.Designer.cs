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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mailForgetPass;
        private TextBox textResetPass;
        private TextBox textBoxCodResetPass;
        private Label codprimitForgetPass;
        private Button button1SendForgetPass;
        private Button codeForgetPass;
    }
}