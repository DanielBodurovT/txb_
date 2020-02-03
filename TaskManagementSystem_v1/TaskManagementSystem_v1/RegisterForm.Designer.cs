namespace TaskManagementSystem_v1
{
    partial class RegisterForm
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
            this.InfoButton = new System.Windows.Forms.Label();
            this.AppLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.BackLabel = new System.Windows.Forms.Label();
            this.NicknameTextBox = new System.Windows.Forms.TextBox();
            this.FinishRegLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoButton
            // 
            this.InfoButton.AutoSize = true;
            this.InfoButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.InfoButton.Location = new System.Drawing.Point(746, 9);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(26, 30);
            this.InfoButton.TabIndex = 8;
            this.InfoButton.Text = "?";
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // AppLabel
            // 
            this.AppLabel.AutoSize = true;
            this.AppLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppLabel.Location = new System.Drawing.Point(225, 83);
            this.AppLabel.Name = "AppLabel";
            this.AppLabel.Size = new System.Drawing.Size(370, 33);
            this.AppLabel.TabIndex = 7;
            this.AppLabel.Text = "Task Management System";
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExitLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.ExitLabel.Location = new System.Drawing.Point(778, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(30, 30);
            this.ExitLabel.TabIndex = 6;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationLabel.Location = new System.Drawing.Point(321, 139);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(178, 33);
            this.RegistrationLabel.TabIndex = 9;
            this.RegistrationLabel.Text = "Registration";
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameLabel.Location = new System.Drawing.Point(231, 245);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(110, 25);
            this.NicknameLabel.TabIndex = 10;
            this.NicknameLabel.Text = "Nickname: ";
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.BackLabel.Location = new System.Drawing.Point(12, 9);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(27, 30);
            this.BackLabel.TabIndex = 11;
            this.BackLabel.Text = "<";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // NicknameTextBox
            // 
            this.NicknameTextBox.Location = new System.Drawing.Point(348, 247);
            this.NicknameTextBox.MaxLength = 31;
            this.NicknameTextBox.Name = "NicknameTextBox";
            this.NicknameTextBox.Size = new System.Drawing.Size(247, 22);
            this.NicknameTextBox.TabIndex = 12;
            // 
            // FinishRegLabel
            // 
            this.FinishRegLabel.AutoSize = true;
            this.FinishRegLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FinishRegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishRegLabel.Location = new System.Drawing.Point(501, 281);
            this.FinishRegLabel.Name = "FinishRegLabel";
            this.FinishRegLabel.Size = new System.Drawing.Size(94, 20);
            this.FinishRegLabel.TabIndex = 13;
            this.FinishRegLabel.Text = "REGISTER";
            this.FinishRegLabel.Click += new System.EventHandler(this.FinishRegLabel_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 524);
            this.Controls.Add(this.FinishRegLabel);
            this.Controls.Add(this.NicknameTextBox);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.NicknameLabel);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.AppLabel);
            this.Controls.Add(this.ExitLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoButton;
        private System.Windows.Forms.Label AppLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.Label BackLabel;
        private System.Windows.Forms.TextBox NicknameTextBox;
        private System.Windows.Forms.Label FinishRegLabel;
    }
}