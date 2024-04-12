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
            this.ConfirmationButtonNumber = new System.Windows.Forms.Button();
            this.ConfirmCodeNumber = new System.Windows.Forms.TextBox();
            this.ConfirmationCodeNumber = new System.Windows.Forms.Label();
            this.VerificationButtonNumber = new System.Windows.Forms.Button();
            this.VerificationCodeNumber = new System.Windows.Forms.TextBox();
            this.labelVfNumar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmationButtonNumber
            // 
            this.ConfirmationButtonNumber.Location = new System.Drawing.Point(399, 158);
            this.ConfirmationButtonNumber.Name = "ConfirmationButtonNumber";
            this.ConfirmationButtonNumber.Size = new System.Drawing.Size(75, 23);
            this.ConfirmationButtonNumber.TabIndex = 11;
            this.ConfirmationButtonNumber.Text = "Confirm";
            this.ConfirmationButtonNumber.UseVisualStyleBackColor = true;
            this.ConfirmationButtonNumber.Click += new System.EventHandler(this.ConfirmationButtonNumber_Click);
            // 
            // ConfirmCodeNumber
            // 
            this.ConfirmCodeNumber.Location = new System.Drawing.Point(280, 130);
            this.ConfirmCodeNumber.Name = "ConfirmCodeNumber";
            this.ConfirmCodeNumber.Size = new System.Drawing.Size(194, 22);
            this.ConfirmCodeNumber.TabIndex = 10;
            // 
            // ConfirmationCodeNumber
            // 
            this.ConfirmationCodeNumber.AutoSize = true;
            this.ConfirmationCodeNumber.Location = new System.Drawing.Point(116, 133);
            this.ConfirmationCodeNumber.Name = "ConfirmationCodeNumber";
            this.ConfirmationCodeNumber.Size = new System.Drawing.Size(102, 16);
            this.ConfirmationCodeNumber.TabIndex = 9;
            this.ConfirmationCodeNumber.Text = "Confirmati codul";
            // 
            // VerificationButtonNumber
            // 
            this.VerificationButtonNumber.Location = new System.Drawing.Point(399, 76);
            this.VerificationButtonNumber.Name = "VerificationButtonNumber";
            this.VerificationButtonNumber.Size = new System.Drawing.Size(75, 23);
            this.VerificationButtonNumber.TabIndex = 8;
            this.VerificationButtonNumber.Text = "Send";
            this.VerificationButtonNumber.UseVisualStyleBackColor = true;
            this.VerificationButtonNumber.Click += new System.EventHandler(this.VerificationButtonNumber_Click);
            // 
            // VerificationCodeNumber
            // 
            this.VerificationCodeNumber.Location = new System.Drawing.Point(280, 48);
            this.VerificationCodeNumber.Name = "VerificationCodeNumber";
            this.VerificationCodeNumber.Size = new System.Drawing.Size(194, 22);
            this.VerificationCodeNumber.TabIndex = 7;
            // 
            // labelVfNumar
            // 
            this.labelVfNumar.AutoSize = true;
            this.labelVfNumar.Location = new System.Drawing.Point(116, 51);
            this.labelVfNumar.Name = "labelVfNumar";
            this.labelVfNumar.Size = new System.Drawing.Size(136, 16);
            this.labelVfNumar.TabIndex = 6;
            this.labelVfNumar.Text = "Reintroduceti numarul";
            // 
            // SmsVerificationApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 207);
            this.Controls.Add(this.ConfirmationButtonNumber);
            this.Controls.Add(this.ConfirmCodeNumber);
            this.Controls.Add(this.ConfirmationCodeNumber);
            this.Controls.Add(this.VerificationButtonNumber);
            this.Controls.Add(this.VerificationCodeNumber);
            this.Controls.Add(this.labelVfNumar);
            this.Name = "SmsVerificationApp";
            this.Text = "SmsVerificationApp";
            this.Load += new System.EventHandler(this.SmsVerificationApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmationButtonNumber;
        private System.Windows.Forms.TextBox ConfirmCodeNumber;
        private System.Windows.Forms.Label ConfirmationCodeNumber;
        private System.Windows.Forms.Button VerificationButtonNumber;
        private System.Windows.Forms.TextBox VerificationCodeNumber;
        private System.Windows.Forms.Label labelVfNumar;
    }
}