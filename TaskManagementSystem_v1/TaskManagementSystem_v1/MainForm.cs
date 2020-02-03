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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void RefreshForm()
        {
            Int32 iId = -1;
            string strNickName = null;
            User.GetCurrentUserInfo(ref iId, ref strNickName);

            if (iId == -1)
            {
                NicknameLabelStatic.Visible = false;
                NicknameLabel.Visible = false;
                LogoutLabel.Visible = false;
                NicknameLabel.Text = "";
                TasksLabel.Visible = false;
                SearchCommentsLabel.Visible = false;

                LoginLabel.Visible = true;
                RegisterLabel.Visible = true;
            }
            else
            {
                LoginLabel.Visible = false;
                RegisterLabel.Visible = false;

                SearchCommentsLabel.Visible = true;
                TasksLabel.Visible = true;
                NicknameLabel.Text = strNickName;
                LogoutLabel.Visible = true;
                NicknameLabel.Visible = true;
                NicknameLabelStatic.Visible = true;
            }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.RefreshForm();
        }

        private void ExitApplicationLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Task Management System\nVersion 0.0.1 alpha\nDaniel Bodurov\n");
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Login = new LoginForm(this);
            Login.Show();
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm Reg = new RegisterForm(this);
            Reg.Show();
        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            User.Logout();
            this.RefreshForm();
        }

        private void TasksLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            TasksForm Tasks = new TasksForm(this);
            Tasks.Show();
        }

        private void SearchCommentsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
