namespace TaskManagementSystem_v1
{
    partial class MainForm
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
            this.ExitApplicationLabel = new System.Windows.Forms.Label();
            this.AppLabel = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.NicknameLabelStatic = new System.Windows.Forms.Label();
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.TasksLabel = new System.Windows.Forms.Label();
            this.SearchCommentsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitApplicationLabel
            // 
            this.ExitApplicationLabel.AutoSize = true;
            this.ExitApplicationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExitApplicationLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.ExitApplicationLabel.Location = new System.Drawing.Point(778, 9);
            this.ExitApplicationLabel.Name = "ExitApplicationLabel";
            this.ExitApplicationLabel.Size = new System.Drawing.Size(30, 30);
            this.ExitApplicationLabel.TabIndex = 0;
            this.ExitApplicationLabel.Text = "X";
            this.ExitApplicationLabel.Click += new System.EventHandler(this.ExitApplicationLabel_Click);
            // 
            // AppLabel
            // 
            this.AppLabel.AutoSize = true;
            this.AppLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppLabel.Location = new System.Drawing.Point(225, 83);
            this.AppLabel.Name = "AppLabel";
            this.AppLabel.Size = new System.Drawing.Size(370, 33);
            this.AppLabel.TabIndex = 1;
            this.AppLabel.Text = "Task Management System";
            // 
            // InfoButton
            // 
            this.InfoButton.AutoSize = true;
            this.InfoButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.InfoButton.Location = new System.Drawing.Point(746, 9);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(26, 30);
            this.InfoButton.TabIndex = 2;
            this.InfoButton.Text = "?";
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.LoginLabel.Location = new System.Drawing.Point(367, 205);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(86, 30);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "LOGIN";
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.RegisterLabel.Location = new System.Drawing.Point(346, 242);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(127, 30);
            this.RegisterLabel.TabIndex = 4;
            this.RegisterLabel.Text = "REGISTER";
            this.RegisterLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            // 
            // NicknameLabelStatic
            // 
            this.NicknameLabelStatic.AutoSize = true;
            this.NicknameLabelStatic.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameLabelStatic.Location = new System.Drawing.Point(12, 456);
            this.NicknameLabelStatic.Name = "NicknameLabelStatic";
            this.NicknameLabelStatic.Size = new System.Drawing.Size(221, 19);
            this.NicknameLabelStatic.TabIndex = 5;
            this.NicknameLabelStatic.Text = "You are currently logged in";
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NicknameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameLabel.ForeColor = System.Drawing.Color.Red;
            this.NicknameLabel.Location = new System.Drawing.Point(16, 485);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(25, 26);
            this.NicknameLabel.TabIndex = 6;
            this.NicknameLabel.Text = "X";
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoutLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.LogoutLabel.Location = new System.Drawing.Point(699, 485);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(109, 30);
            this.LogoutLabel.TabIndex = 7;
            this.LogoutLabel.Text = "LOGOUT";
            this.LogoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // TasksLabel
            // 
            this.TasksLabel.AutoSize = true;
            this.TasksLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TasksLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.TasksLabel.Location = new System.Drawing.Point(333, 279);
            this.TasksLabel.Name = "TasksLabel";
            this.TasksLabel.Size = new System.Drawing.Size(153, 30);
            this.TasksLabel.TabIndex = 8;
            this.TasksLabel.Text = "VIEW TASKS";
            this.TasksLabel.Click += new System.EventHandler(this.TasksLabel_Click);
            // 
            // SearchCommentsLabel
            // 
            this.SearchCommentsLabel.AutoSize = true;
            this.SearchCommentsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.SearchCommentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchCommentsLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.SearchCommentsLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.SearchCommentsLabel.Location = new System.Drawing.Point(288, 316);
            this.SearchCommentsLabel.Name = "SearchCommentsLabel";
            this.SearchCommentsLabel.Size = new System.Drawing.Size(244, 30);
            this.SearchCommentsLabel.TabIndex = 9;
            this.SearchCommentsLabel.Text = "SEARCH COMMENTS";
            this.SearchCommentsLabel.Click += new System.EventHandler(this.SearchCommentsLabel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 524);
            this.Controls.Add(this.SearchCommentsLabel);
            this.Controls.Add(this.TasksLabel);
            this.Controls.Add(this.LogoutLabel);
            this.Controls.Add(this.NicknameLabel);
            this.Controls.Add(this.NicknameLabelStatic);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.AppLabel);
            this.Controls.Add(this.ExitApplicationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitApplicationLabel;
        private System.Windows.Forms.Label AppLabel;
        private System.Windows.Forms.Label InfoButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Label NicknameLabelStatic;
        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.Label LogoutLabel;
        private System.Windows.Forms.Label TasksLabel;
        private System.Windows.Forms.Label SearchCommentsLabel;
    }
}