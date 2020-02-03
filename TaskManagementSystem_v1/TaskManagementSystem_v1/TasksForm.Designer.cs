namespace TaskManagementSystem_v1
{
    partial class TasksForm
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
            this.BackLabel = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Label();
            this.AppLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.TasksListLabel = new System.Windows.Forms.Label();
            this.TasksListBox = new System.Windows.Forms.ListBox();
            this.TaskDescrTextBox = new System.Windows.Forms.RichTextBox();
            this.TaskCreatedDateLabel = new System.Windows.Forms.Label();
            this.TaskRequiredByDateLabel = new System.Windows.Forms.Label();
            this.TaskStatusLabel = new System.Windows.Forms.Label();
            this.TaskTypeLabel = new System.Windows.Forms.Label();
            this.TaskNextActionDateLabel = new System.Windows.Forms.Label();
            this.TaskAssignedToListBox = new System.Windows.Forms.ListBox();
            this.TaskDescrLabel = new System.Windows.Forms.Label();
            this.TaskAssignedToLabel = new System.Windows.Forms.Label();
            this.AddNewTaskLabel = new System.Windows.Forms.Label();
            this.RemoveTaskLabel = new System.Windows.Forms.Label();
            this.EditTaskLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.BackLabel.Location = new System.Drawing.Point(12, 9);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(27, 30);
            this.BackLabel.TabIndex = 22;
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
            this.InfoButton.TabIndex = 21;
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
            this.AppLabel.TabIndex = 20;
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
            this.ExitLabel.TabIndex = 19;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // TasksListLabel
            // 
            this.TasksListLabel.AutoSize = true;
            this.TasksListLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksListLabel.Location = new System.Drawing.Point(12, 127);
            this.TasksListLabel.Name = "TasksListLabel";
            this.TasksListLabel.Size = new System.Drawing.Size(65, 19);
            this.TasksListLabel.TabIndex = 23;
            this.TasksListLabel.Text = "Tasks: ";
            // 
            // TasksListBox
            // 
            this.TasksListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TasksListBox.FormattingEnabled = true;
            this.TasksListBox.ItemHeight = 16;
            this.TasksListBox.Location = new System.Drawing.Point(84, 127);
            this.TasksListBox.Name = "TasksListBox";
            this.TasksListBox.Size = new System.Drawing.Size(120, 324);
            this.TasksListBox.TabIndex = 24;
            this.TasksListBox.SelectedIndexChanged += new System.EventHandler(this.TasksListBox_SelectedIndexChanged);
            // 
            // TaskDescrTextBox
            // 
            this.TaskDescrTextBox.Location = new System.Drawing.Point(231, 147);
            this.TaskDescrTextBox.MaxLength = 255;
            this.TaskDescrTextBox.Name = "TaskDescrTextBox";
            this.TaskDescrTextBox.Size = new System.Drawing.Size(541, 96);
            this.TaskDescrTextBox.TabIndex = 25;
            this.TaskDescrTextBox.Text = "";
            // 
            // TaskCreatedDateLabel
            // 
            this.TaskCreatedDateLabel.AutoSize = true;
            this.TaskCreatedDateLabel.Location = new System.Drawing.Point(228, 283);
            this.TaskCreatedDateLabel.Name = "TaskCreatedDateLabel";
            this.TaskCreatedDateLabel.Size = new System.Drawing.Size(82, 17);
            this.TaskCreatedDateLabel.TabIndex = 26;
            this.TaskCreatedDateLabel.Text = "Created on:";
            // 
            // TaskRequiredByDateLabel
            // 
            this.TaskRequiredByDateLabel.AutoSize = true;
            this.TaskRequiredByDateLabel.Location = new System.Drawing.Point(228, 300);
            this.TaskRequiredByDateLabel.Name = "TaskRequiredByDateLabel";
            this.TaskRequiredByDateLabel.Size = new System.Drawing.Size(93, 17);
            this.TaskRequiredByDateLabel.TabIndex = 27;
            this.TaskRequiredByDateLabel.Text = "Required by: ";
            // 
            // TaskStatusLabel
            // 
            this.TaskStatusLabel.AutoSize = true;
            this.TaskStatusLabel.Location = new System.Drawing.Point(228, 246);
            this.TaskStatusLabel.Name = "TaskStatusLabel";
            this.TaskStatusLabel.Size = new System.Drawing.Size(91, 17);
            this.TaskStatusLabel.TabIndex = 28;
            this.TaskStatusLabel.Text = "Task Status: ";
            // 
            // TaskTypeLabel
            // 
            this.TaskTypeLabel.AutoSize = true;
            this.TaskTypeLabel.Location = new System.Drawing.Point(517, 246);
            this.TaskTypeLabel.Name = "TaskTypeLabel";
            this.TaskTypeLabel.Size = new System.Drawing.Size(83, 17);
            this.TaskTypeLabel.TabIndex = 29;
            this.TaskTypeLabel.Text = "Task Type: ";
            // 
            // TaskNextActionDateLabel
            // 
            this.TaskNextActionDateLabel.AutoSize = true;
            this.TaskNextActionDateLabel.Location = new System.Drawing.Point(228, 334);
            this.TaskNextActionDateLabel.Name = "TaskNextActionDateLabel";
            this.TaskNextActionDateLabel.Size = new System.Drawing.Size(106, 17);
            this.TaskNextActionDateLabel.TabIndex = 30;
            this.TaskNextActionDateLabel.Text = "Next action on: ";
            // 
            // TaskAssignedToListBox
            // 
            this.TaskAssignedToListBox.FormattingEnabled = true;
            this.TaskAssignedToListBox.ItemHeight = 16;
            this.TaskAssignedToListBox.Location = new System.Drawing.Point(520, 303);
            this.TaskAssignedToListBox.Name = "TaskAssignedToListBox";
            this.TaskAssignedToListBox.Size = new System.Drawing.Size(252, 148);
            this.TaskAssignedToListBox.TabIndex = 31;
            this.TaskAssignedToListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TaskDescrLabel
            // 
            this.TaskDescrLabel.AutoSize = true;
            this.TaskDescrLabel.Location = new System.Drawing.Point(228, 127);
            this.TaskDescrLabel.Name = "TaskDescrLabel";
            this.TaskDescrLabel.Size = new System.Drawing.Size(87, 17);
            this.TaskDescrLabel.TabIndex = 32;
            this.TaskDescrLabel.Text = "Description: ";
            // 
            // TaskAssignedToLabel
            // 
            this.TaskAssignedToLabel.AutoSize = true;
            this.TaskAssignedToLabel.Location = new System.Drawing.Point(517, 283);
            this.TaskAssignedToLabel.Name = "TaskAssignedToLabel";
            this.TaskAssignedToLabel.Size = new System.Drawing.Size(86, 17);
            this.TaskAssignedToLabel.TabIndex = 33;
            this.TaskAssignedToLabel.Text = "Assigned to:";
            // 
            // AddNewTaskLabel
            // 
            this.AddNewTaskLabel.AutoSize = true;
            this.AddNewTaskLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddNewTaskLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.AddNewTaskLabel.Location = new System.Drawing.Point(86, 98);
            this.AddNewTaskLabel.Name = "AddNewTaskLabel";
            this.AddNewTaskLabel.Size = new System.Drawing.Size(117, 26);
            this.AddNewTaskLabel.TabIndex = 34;
            this.AddNewTaskLabel.Text = "NEW  TASK";
            this.AddNewTaskLabel.Click += new System.EventHandler(this.AddNewTaskLabel_Click);
            // 
            // RemoveTaskLabel
            // 
            this.RemoveTaskLabel.AutoSize = true;
            this.RemoveTaskLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemoveTaskLabel.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.RemoveTaskLabel.Location = new System.Drawing.Point(82, 483);
            this.RemoveTaskLabel.Name = "RemoveTaskLabel";
            this.RemoveTaskLabel.Size = new System.Drawing.Size(124, 21);
            this.RemoveTaskLabel.TabIndex = 35;
            this.RemoveTaskLabel.Text = "REMOVE TASK";
            this.RemoveTaskLabel.Click += new System.EventHandler(this.RemoveTaskLabel_Click);
            // 
            // EditTaskLabel
            // 
            this.EditTaskLabel.AutoSize = true;
            this.EditTaskLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditTaskLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.EditTaskLabel.Location = new System.Drawing.Point(85, 454);
            this.EditTaskLabel.Name = "EditTaskLabel";
            this.EditTaskLabel.Size = new System.Drawing.Size(118, 26);
            this.EditTaskLabel.TabIndex = 36;
            this.EditTaskLabel.Text = "EDIT  TASK";
            this.EditTaskLabel.Click += new System.EventHandler(this.EditTaskLabel_Click);
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 524);
            this.Controls.Add(this.EditTaskLabel);
            this.Controls.Add(this.RemoveTaskLabel);
            this.Controls.Add(this.AddNewTaskLabel);
            this.Controls.Add(this.TaskAssignedToLabel);
            this.Controls.Add(this.TaskDescrLabel);
            this.Controls.Add(this.TaskAssignedToListBox);
            this.Controls.Add(this.TaskNextActionDateLabel);
            this.Controls.Add(this.TaskTypeLabel);
            this.Controls.Add(this.TaskStatusLabel);
            this.Controls.Add(this.TaskRequiredByDateLabel);
            this.Controls.Add(this.TaskCreatedDateLabel);
            this.Controls.Add(this.TaskDescrTextBox);
            this.Controls.Add(this.TasksListBox);
            this.Controls.Add(this.TasksListLabel);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.AppLabel);
            this.Controls.Add(this.ExitLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TasksForm";
            this.Text = "TasksForm";
            this.Load += new System.EventHandler(this.TasksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BackLabel;
        private System.Windows.Forms.Label InfoButton;
        private System.Windows.Forms.Label AppLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label TasksListLabel;
        private System.Windows.Forms.ListBox TasksListBox;
        private System.Windows.Forms.RichTextBox TaskDescrTextBox;
        private System.Windows.Forms.Label TaskCreatedDateLabel;
        private System.Windows.Forms.Label TaskRequiredByDateLabel;
        private System.Windows.Forms.Label TaskStatusLabel;
        private System.Windows.Forms.Label TaskTypeLabel;
        private System.Windows.Forms.Label TaskNextActionDateLabel;
        private System.Windows.Forms.ListBox TaskAssignedToListBox;
        private System.Windows.Forms.Label TaskDescrLabel;
        private System.Windows.Forms.Label TaskAssignedToLabel;
        private System.Windows.Forms.Label AddNewTaskLabel;
        private System.Windows.Forms.Label RemoveTaskLabel;
        private System.Windows.Forms.Label EditTaskLabel;
    }
}