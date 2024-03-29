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
            NewResetPass.Location = new Point(86, 59);
            NewResetPass.Name = "NewResetPass";
            NewResetPass.Size = new Size(90, 20);
            NewResetPass.TabIndex = 0;
            NewResetPass.Text = "Noua Parola";
            // 
            // ConfirmNewPass
            // 
            ConfirmNewPass.AutoSize = true;
            ConfirmNewPass.Location = new Point(86, 127);
            ConfirmNewPass.Name = "ConfirmNewPass";
            ConfirmNewPass.Size = new Size(79, 20);
            ConfirmNewPass.TabIndex = 1;
            ConfirmNewPass.Text = "Confirmati";
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.Location = new Point(193, 56);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.Size = new Size(225, 27);
            textBoxNewPass.TabIndex = 2;
            // 
            // textBoxConfirmNewPass
            // 
            textBoxConfirmNewPass.Location = new Point(193, 124);
            textBoxConfirmNewPass.Name = "textBoxConfirmNewPass";
            textBoxConfirmNewPass.Size = new Size(225, 27);
            textBoxConfirmNewPass.TabIndex = 3;
            // 
            // submitNewPass
            // 
            submitNewPass.Location = new Point(324, 173);
            submitNewPass.Name = "submitNewPass";
            submitNewPass.Size = new Size(94, 29);
            submitNewPass.TabIndex = 4;
            submitNewPass.Text = "reset";
            submitNewPass.UseVisualStyleBackColor = true;
            submitNewPass.Click += submitNewPass_Click;
            // 
            // ResetPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 264);
            Controls.Add(submitNewPass);
            Controls.Add(textBoxConfirmNewPass);
            Controls.Add(textBoxNewPass);
            Controls.Add(ConfirmNewPass);
            Controls.Add(NewResetPass);
            Name = "ResetPass";
            Text = "ResetPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NewResetPass;
        private Label ConfirmNewPass;
        private TextBox textBoxNewPass;
        private TextBox textBoxConfirmNewPass;
        private Button submitNewPass;
    }
}