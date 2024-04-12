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
            CodVerificare = new Label();
            VerificationCode = new TextBox();
            VerificationButton = new Button();
            ConfirmationCode = new Label();
            ConfirmCode = new TextBox();
            ConfirmationButton = new Button();
            SuspendLayout();
            // 
            // CodVerificare
            // 
            CodVerificare.AutoSize = true;
            CodVerificare.Location = new Point(16, 31);
            CodVerificare.Name = "CodVerificare";
            CodVerificare.Size = new Size(157, 15);
            CodVerificare.TabIndex = 0;
            CodVerificare.Text = "Reintroduceti adresa de mail";
            // 
            // VerificationCode
            // 
            VerificationCode.Location = new Point(184, 28);
            VerificationCode.Name = "VerificationCode";
            VerificationCode.Size = new Size(170, 23);
            VerificationCode.TabIndex = 1;
            // 
            // VerificationButton
            // 
            VerificationButton.Location = new Point(288, 54);
            VerificationButton.Name = "VerificationButton";
            VerificationButton.Size = new Size(66, 22);
            VerificationButton.TabIndex = 2;
            VerificationButton.Text = "Send";
            VerificationButton.UseVisualStyleBackColor = true;
            VerificationButton.Click += VerificationButton_Click;
            // 
            // ConfirmationCode
            // 
            ConfirmationCode.AutoSize = true;
            ConfirmationCode.Location = new Point(16, 111);
            ConfirmationCode.Name = "ConfirmationCode";
            ConfirmationCode.Size = new Size(97, 15);
            ConfirmationCode.TabIndex = 3;
            ConfirmationCode.Text = "Confirmati codul";
            // 
            // ConfirmCode
            // 
            ConfirmCode.Location = new Point(184, 108);
            ConfirmCode.Name = "ConfirmCode";
            ConfirmCode.Size = new Size(170, 23);
            ConfirmCode.TabIndex = 4;
            // 
            // ConfirmationButton
            // 
            ConfirmationButton.Location = new Point(288, 134);
            ConfirmationButton.Name = "ConfirmationButton";
            ConfirmationButton.Size = new Size(66, 22);
            ConfirmationButton.TabIndex = 5;
            ConfirmationButton.Text = "Confirm";
            ConfirmationButton.UseVisualStyleBackColor = true;
            ConfirmationButton.Click += ConfirmationButton_Click;
            // 
            // VerificationMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 176);
            Controls.Add(ConfirmationButton);
            Controls.Add(ConfirmCode);
            Controls.Add(ConfirmationCode);
            Controls.Add(VerificationButton);
            Controls.Add(VerificationCode);
            Controls.Add(CodVerificare);
            Name = "VerificationMail";
            Text = "VerificationMail";
            Load += VerificationMail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label CodVerificare;
        private System.Windows.Forms.TextBox VerificationCode;
        private System.Windows.Forms.Button VerificationButton;
        private System.Windows.Forms.Label ConfirmationCode;
        private System.Windows.Forms.TextBox ConfirmCode;
        private System.Windows.Forms.Button ConfirmationButton;
    }
}