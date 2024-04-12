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
            // ResetPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 198);
            Controls.Add(submitNewPass);
            Controls.Add(textBoxConfirmNewPass);
            Controls.Add(textBoxNewPass);
            Controls.Add(ConfirmNewPass);
            Controls.Add(NewResetPass);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ResetPass";
            Text = "ResetPass";
            Load += ResetPass_Load;
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