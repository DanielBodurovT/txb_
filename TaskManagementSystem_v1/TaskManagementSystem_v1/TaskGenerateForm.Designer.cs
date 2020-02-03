namespace TaskManagementSystem_v1
{
    partial class TaskGenerateForm
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
            this.TaskAssignedToLabel = new System.Windows.Forms.Label();
            this.TaskDescrLabel = new System.Windows.Forms.Label();
            this.TaskAssignedToListBox = new System.Windows.Forms.ListBox();
            this.TaskDescrTextBox = new System.Windows.Forms.RichTextBox();
            this.BackLabel = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Label();
            this.AppLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.FreeUsersListBox = new System.Windows.Forms.ListBox();
            this.FreeUsersLabel = new System.Windows.Forms.Label();
            this.AssignButton = new System.Windows.Forms.Button();
            this.UnAssignButton = new System.Windows.Forms.Button();
            this.TaskTypeLabel = new System.Windows.Forms.Label();
            this.TaskStatusLabel = new System.Windows.Forms.Label();
            this.TaskTypeComboBox = new System.Windows.Forms.ComboBox();
            this.TaskStatusComboBox = new System.Windows.Forms.ComboBox();
            this.TaskRequiredByDateLabel = new System.Windows.Forms.Label();
            this.TaskCreatedDateLabel = new System.Windows.Forms.Label();
            this.CreatedOnChangeButton = new System.Windows.Forms.Button();
            this.RequiredByChangeButton = new System.Windows.Forms.Button();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskAssignedToLabel
            // 
            this.TaskAssignedToLabel.AutoSize = true;
            this.TaskAssignedToLabel.Location = new System.Drawing.Point(298, 294);
            this.TaskAssignedToLabel.Name = "TaskAssignedToLabel";
            this.TaskAssignedToLabel.Size = new System.Drawing.Size(86, 17);
            this.TaskAssignedToLabel.TabIndex = 51;
            this.TaskAssignedToLabel.Text = "Assigned to:";
            // 
            // TaskDescrLabel
            // 
            this.TaskDescrLabel.AutoSize = true;
            this.TaskDescrLabel.Location = new System.Drawing.Point(228, 127);
            this.TaskDescrLabel.Name = "TaskDescrLabel";
            this.TaskDescrLabel.Size = new System.Drawing.Size(87, 17);
            this.TaskDescrLabel.TabIndex = 50;
            this.TaskDescrLabel.Text = "Description: ";
            // 
            // TaskAssignedToListBox
            // 
            this.TaskAssignedToListBox.FormattingEnabled = true;
            this.TaskAssignedToListBox.ItemHeight = 16;
            this.TaskAssignedToListBox.Location = new System.Drawing.Point(301, 314);
            this.TaskAssignedToListBox.Name = "TaskAssignedToListBox";
            this.TaskAssignedToListBox.Size = new System.Drawing.Size(252, 148);
            this.TaskAssignedToListBox.TabIndex = 49;
            // 
            // TaskDescrTextBox
            // 
            this.TaskDescrTextBox.Location = new System.Drawing.Point(231, 147);
            this.TaskDescrTextBox.MaxLength = 255;
            this.TaskDescrTextBox.Name = "TaskDescrTextBox";
            this.TaskDescrTextBox.Size = new System.Drawing.Size(541, 96);
            this.TaskDescrTextBox.TabIndex = 43;
            this.TaskDescrTextBox.Text = "";
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.BackLabel.Location = new System.Drawing.Point(12, 9);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(27, 30);
            this.BackLabel.TabIndex = 40;
            this.BackLabel.Text = "<";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.AutoSize = true;
            this.InfoButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.InfoButton.Location = new System.Drawing.Point(746, 9);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(26, 30);
            this.InfoButton.TabIndex = 39;
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
            this.AppLabel.TabIndex = 38;
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
            this.ExitLabel.TabIndex = 37;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // FreeUsersListBox
            // 
            this.FreeUsersListBox.FormattingEnabled = true;
            this.FreeUsersListBox.ItemHeight = 16;
            this.FreeUsersListBox.Location = new System.Drawing.Point(12, 314);
            this.FreeUsersListBox.Name = "FreeUsersListBox";
            this.FreeUsersListBox.Size = new System.Drawing.Size(252, 148);
            this.FreeUsersListBox.TabIndex = 52;
            // 
            // FreeUsersLabel
            // 
            this.FreeUsersLabel.AutoSize = true;
            this.FreeUsersLabel.Location = new System.Drawing.Point(10, 294);
            this.FreeUsersLabel.Name = "FreeUsersLabel";
            this.FreeUsersLabel.Size = new System.Drawing.Size(80, 17);
            this.FreeUsersLabel.TabIndex = 53;
            this.FreeUsersLabel.Text = "Free users:";
            // 
            // AssignButton
            // 
            this.AssignButton.Location = new System.Drawing.Point(189, 468);
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(75, 28);
            this.AssignButton.TabIndex = 54;
            this.AssignButton.Text = "Assign";
            this.AssignButton.UseVisualStyleBackColor = true;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // UnAssignButton
            // 
            this.UnAssignButton.Location = new System.Drawing.Point(478, 468);
            this.UnAssignButton.Name = "UnAssignButton";
            this.UnAssignButton.Size = new System.Drawing.Size(75, 28);
            this.UnAssignButton.TabIndex = 55;
            this.UnAssignButton.Text = "Unassign";
            this.UnAssignButton.UseVisualStyleBackColor = true;
            this.UnAssignButton.Click += new System.EventHandler(this.UnAssignButton_Click);
            // 
            // TaskTypeLabel
            // 
            this.TaskTypeLabel.AutoSize = true;
            this.TaskTypeLabel.Location = new System.Drawing.Point(9, 147);
            this.TaskTypeLabel.Name = "TaskTypeLabel";
            this.TaskTypeLabel.Size = new System.Drawing.Size(83, 17);
            this.TaskTypeLabel.TabIndex = 57;
            this.TaskTypeLabel.Text = "Task Type: ";
            // 
            // TaskStatusLabel
            // 
            this.TaskStatusLabel.AutoSize = true;
            this.TaskStatusLabel.Location = new System.Drawing.Point(9, 184);
            this.TaskStatusLabel.Name = "TaskStatusLabel";
            this.TaskStatusLabel.Size = new System.Drawing.Size(91, 17);
            this.TaskStatusLabel.TabIndex = 56;
            this.TaskStatusLabel.Text = "Task Status: ";
            // 
            // TaskTypeComboBox
            // 
            this.TaskTypeComboBox.FormattingEnabled = true;
            this.TaskTypeComboBox.Location = new System.Drawing.Point(106, 147);
            this.TaskTypeComboBox.Name = "TaskTypeComboBox";
            this.TaskTypeComboBox.Size = new System.Drawing.Size(118, 24);
            this.TaskTypeComboBox.TabIndex = 58;
            // 
            // TaskStatusComboBox
            // 
            this.TaskStatusComboBox.FormattingEnabled = true;
            this.TaskStatusComboBox.Location = new System.Drawing.Point(106, 177);
            this.TaskStatusComboBox.Name = "TaskStatusComboBox";
            this.TaskStatusComboBox.Size = new System.Drawing.Size(118, 24);
            this.TaskStatusComboBox.TabIndex = 59;
            // 
            // TaskRequiredByDateLabel
            // 
            this.TaskRequiredByDateLabel.AutoSize = true;
            this.TaskRequiredByDateLabel.Location = new System.Drawing.Point(532, 246);
            this.TaskRequiredByDateLabel.Name = "TaskRequiredByDateLabel";
            this.TaskRequiredByDateLabel.Size = new System.Drawing.Size(93, 17);
            this.TaskRequiredByDateLabel.TabIndex = 61;
            this.TaskRequiredByDateLabel.Text = "Required by: ";
            // 
            // TaskCreatedDateLabel
            // 
            this.TaskCreatedDateLabel.AutoSize = true;
            this.TaskCreatedDateLabel.Location = new System.Drawing.Point(229, 246);
            this.TaskCreatedDateLabel.Name = "TaskCreatedDateLabel";
            this.TaskCreatedDateLabel.Size = new System.Drawing.Size(82, 17);
            this.TaskCreatedDateLabel.TabIndex = 60;
            this.TaskCreatedDateLabel.Text = "Created on:";
            // 
            // CreatedOnChangeButton
            // 
            this.CreatedOnChangeButton.Location = new System.Drawing.Point(231, 263);
            this.CreatedOnChangeButton.Name = "CreatedOnChangeButton";
            this.CreatedOnChangeButton.Size = new System.Drawing.Size(75, 28);
            this.CreatedOnChangeButton.TabIndex = 62;
            this.CreatedOnChangeButton.Text = "Change";
            this.CreatedOnChangeButton.UseVisualStyleBackColor = true;
            this.CreatedOnChangeButton.Click += new System.EventHandler(this.CreatedOnChangeButton_Click);
            // 
            // RequiredByChangeButton
            // 
            this.RequiredByChangeButton.Location = new System.Drawing.Point(535, 263);
            this.RequiredByChangeButton.Name = "RequiredByChangeButton";
            this.RequiredByChangeButton.Size = new System.Drawing.Size(75, 28);
            this.RequiredByChangeButton.TabIndex = 63;
            this.RequiredByChangeButton.Text = "Change";
            this.RequiredByChangeButton.UseVisualStyleBackColor = true;
            this.RequiredByChangeButton.Click += new System.EventHandler(this.RequiredByChangeButton_Click);
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SaveLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLabel.Location = new System.Drawing.Point(681, 427);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(91, 35);
            this.SaveLabel.TabIndex = 64;
            this.SaveLabel.Text = "SAVE";
            this.SaveLabel.Click += new System.EventHandler(this.SaveLabel_Click);
            // 
            // TaskGenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 524);
            this.Controls.Add(this.SaveLabel);
            this.Controls.Add(this.RequiredByChangeButton);
            this.Controls.Add(this.CreatedOnChangeButton);
            this.Controls.Add(this.TaskRequiredByDateLabel);
            this.Controls.Add(this.TaskCreatedDateLabel);
            this.Controls.Add(this.TaskStatusComboBox);
            this.Controls.Add(this.TaskTypeComboBox);
            this.Controls.Add(this.TaskTypeLabel);
            this.Controls.Add(this.TaskStatusLabel);
            this.Controls.Add(this.UnAssignButton);
            this.Controls.Add(this.AssignButton);
            this.Controls.Add(this.FreeUsersLabel);
            this.Controls.Add(this.FreeUsersListBox);
            this.Controls.Add(this.TaskAssignedToLabel);
            this.Controls.Add(this.TaskDescrLabel);
            this.Controls.Add(this.TaskAssignedToListBox);
            this.Controls.Add(this.TaskDescrTextBox);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.AppLabel);
            this.Controls.Add(this.ExitLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskGenerateForm";
            this.Text = "TaskGenerateForm";
            this.Load += new System.EventHandler(this.TaskGenerateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskAssignedToLabel;
        private System.Windows.Forms.Label TaskDescrLabel;
        private System.Windows.Forms.ListBox TaskAssignedToListBox;
        private System.Windows.Forms.RichTextBox TaskDescrTextBox;
        private System.Windows.Forms.Label BackLabel;
        private System.Windows.Forms.Label InfoButton;
        private System.Windows.Forms.Label AppLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.ListBox FreeUsersListBox;
        private System.Windows.Forms.Label FreeUsersLabel;
        private System.Windows.Forms.Button AssignButton;
        private System.Windows.Forms.Button UnAssignButton;
        private System.Windows.Forms.Label TaskTypeLabel;
        private System.Windows.Forms.Label TaskStatusLabel;
        private System.Windows.Forms.ComboBox TaskTypeComboBox;
        private System.Windows.Forms.ComboBox TaskStatusComboBox;
        private System.Windows.Forms.Label TaskRequiredByDateLabel;
        private System.Windows.Forms.Label TaskCreatedDateLabel;
        private System.Windows.Forms.Button CreatedOnChangeButton;
        private System.Windows.Forms.Button RequiredByChangeButton;
        private System.Windows.Forms.Label SaveLabel;
    }
}