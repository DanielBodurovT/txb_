using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagementSystem_v1
{
    public partial class TasksForm : Form
    {
        private MainForm retForm = null;
        public TasksForm(MainForm mForm)
        {
            retForm = mForm;
            InitializeComponent();
        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
            foreach(Int32 iTask in DBManager.GetTasksList())
            { 
                this.TasksListBox.Items.Add(String.Format("Task {0}", iTask));
            }
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            retForm.RefreshForm();
            retForm.Show();
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            retForm.RefreshForm();
            retForm.Show();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Task Management System\nVersion 0.0.1 alpha\nDaniel Bodurov\n");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TasksListBox.SelectedItem == null)
                return;

            string strSelectedTask = TasksListBox.SelectedItem.ToString();
            Int32 iTaskId = Int32.Parse(strSelectedTask.Remove(0, 5));
            
            Task tTask = DBManager.GetTaskData(iTaskId);

            TaskDescrTextBox.Text = tTask.GetDescription();

            TaskCreatedDateLabel.Text = String.Format("Created on: {0}",
                tTask.GetCreationDate().ToString());
            TaskRequiredByDateLabel.Text = String.Format("Required by: {0}",
                tTask.GetRequiredByDate().ToString());
            TaskNextActionDateLabel.Text = String.Format("Next action on: {0}",
                tTask.GetNextActionDate().ToString());



            TaskTypeLabel.Text = String.Format("Task Type: {0}",
                DBManager.GetTaskType(tTask.GetTaskType()));
            TaskStatusLabel.Text = String.Format("Task Status: {0}",
                DBManager.GetTaskStatus(tTask.GetTaskStatus()));

            foreach (Int32 iUserId in tTask.GetAssignedToList())
            {
                TaskAssignedToListBox.Items.Add(DBManager.DB_GetUserNickname(iUserId));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddNewTaskLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            TaskGenerateForm TaskGenerate = new TaskGenerateForm(this.retForm, -1); // to do: remove this magic number
            TaskGenerate.Show();
        }

        private void EditTaskLabel_Click(object sender, EventArgs e)
        {
            if (TasksListBox.SelectedItem == null)
                return;

            string strSelectedTask = TasksListBox.SelectedItem.ToString();
            Int32 iTaskId = Int32.Parse(strSelectedTask.Remove(0, 5));

            this.Close();
            TaskGenerateForm TaskGenerate = new TaskGenerateForm(this.retForm, iTaskId);
            TaskGenerate.Show();
        }

        private void RemoveTaskLabel_Click(object sender, EventArgs e)
        {
            if (TasksListBox.SelectedItem == null)
                return;

            string strSelectedTask = TasksListBox.SelectedItem.ToString();
            Int32 iTaskId = Int32.Parse(strSelectedTask.Remove(0, 5));

            DBManager.RemoveTask(iTaskId);

            this.Close();
            TasksForm Tasks = new TasksForm(this.retForm);
            Tasks.Show();
        }
    }
}
