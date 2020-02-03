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
    public partial class TaskGenerateForm : Form
    {
        private MainForm retForm = null;

        private Int32 iSelectedTaskId;
        private Task tTask = null;

        private Dictionary<Int32, string> TaskTypes = new Dictionary<Int32, string>();
        private Dictionary<Int32, string> TaskStatuses = new Dictionary<Int32, string>();

        public TaskGenerateForm(MainForm mForm, Int32 iTaskId)
        {
            retForm = mForm;
            iSelectedTaskId = iTaskId;

            if (iTaskId == -1) // to do: remove this magic number
                tTask = new Task();
            else
                tTask = DBManager.GetTaskData(iTaskId);

            InitializeComponent();

            TaskTypes = DBManager.GetAllTaskTypes();
            TaskStatuses = DBManager.GetAllTaskStatuses();

            foreach (KeyValuePair<Int32, string> kvp in TaskTypes)
                TaskTypeComboBox.Items.Add(kvp.Value);

            foreach (KeyValuePair<Int32, string> kvp in TaskStatuses)
                TaskStatusComboBox.Items.Add(kvp.Value);
        }

        private void TaskGenerateForm_Load(object sender, EventArgs e)
        {
            if(iSelectedTaskId == -1) // to do: remove this magic number
            {
                foreach (string strName in DBManager.GetUserList())
                    FreeUsersListBox.Items.Add(strName);
            }
            else
            {
                TaskDescrTextBox.Text = tTask.GetDescription();

                TaskCreatedDateLabel.Text = String.Format("Created on: {0}",
                    tTask.GetCreationDate());
                TaskRequiredByDateLabel.Text = String.Format("Required by: {0}",
                    tTask.GetRequiredByDate());

                foreach(KeyValuePair<Int32, string> kvp in TaskTypes)
                {
                    if (kvp.Value.Equals(DBManager.GetTaskType(tTask.GetTaskType())))
                    {
                        TaskTypeComboBox.SelectedIndex = kvp.Key - 1;
                        break;
                    }
                }

                foreach (KeyValuePair<Int32, string> kvp in TaskStatuses)
                {
                    if (kvp.Value.Equals(DBManager.GetTaskStatus(tTask.GetTaskStatus())))
                    {
                        TaskStatusComboBox.SelectedIndex = kvp.Key - 1;
                        break;
                    }
                }
                

                foreach (string strName in DBManager.GetUserListUnassignedForTask(iSelectedTaskId))
                    FreeUsersListBox.Items.Add(strName);

                foreach (string strName in DBManager.GetUserListAssignedForTask(iSelectedTaskId))
                    TaskAssignedToListBox.Items.Add(strName);
            }
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            TasksForm Tasks = new TasksForm(retForm);
            Tasks.Show();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            TasksForm Tasks = new TasksForm(retForm);
            Tasks.Show();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Task Management System\nVersion 0.0.1 alpha\nDaniel Bodurov\n");
        }

        private void SaveLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreatedOnChangeButton_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            CalendarForm f = new CalendarForm(ref date);
            // door for many bugs, method needs to be improved...
            f.Show();

            TaskCreatedDateLabel.Text = String.Format("Created on: {0}",
                date.ToString()); // needs refresh
        }

        private void RequiredByChangeButton_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            CalendarForm f = new CalendarForm(ref date);
            // door for many bugs, method needs to be improved...
            f.Show();

            TaskRequiredByDateLabel.Text = String.Format("Created on: {0}",
                date.ToString()); // needs refresh
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            if (iSelectedTaskId == -1)
                return;

            if (FreeUsersListBox.SelectedItem == null)
                return;

            string strSelectedUser = FreeUsersListBox.SelectedItem.ToString();

            Int32 iUserId = DBManager.DB_LookUpUser(strSelectedUser);
            DBManager.DB_AssignTaskToUser(iUserId, iSelectedTaskId);

            TaskGenerateForm refresh = new TaskGenerateForm(retForm, iSelectedTaskId);
            refresh.Show();
            this.Close();
        }

        private void UnAssignButton_Click(object sender, EventArgs e)
        {
            if (TaskAssignedToListBox.SelectedItem == null)
                return;

            string strSelectedUser = TaskAssignedToListBox.SelectedItem.ToString();

            Int32 iUserId = DBManager.DB_LookUpUser(strSelectedUser);
            DBManager.DB_UnAssignTaskToUser(iUserId, iSelectedTaskId);

            TaskGenerateForm refresh = new TaskGenerateForm(retForm, iSelectedTaskId);
            refresh.Show();
            this.Close();
        }
    }
}
