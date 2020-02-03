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
    public partial class LoginForm : Form
    {
        private MainForm retForm = null;
        public LoginForm(MainForm mForm)
        {
            retForm = mForm;
            InitializeComponent();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Task Management System\nVersion 0.0.1 alpha\nDaniel Bodurov\n");
        }

        private void AppLabel_Click(object sender, EventArgs e)
        {
        }

        private void ExitApplicationLabel_Click(object sender, EventArgs e) // need rename 
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

        private void FinishRegLabel_Click(object sender, EventArgs e)
        {
            if (NicknameTextBox == null || NicknameTextBox.Text == null)
            {
                MessageBox.Show("Error!");
                return;
            }

            string strNickname = NicknameTextBox.Text;

            if (strNickname.Length < 1)
            {
                MessageBox.Show("There is no data entered!");
                return;
            }

            if (strNickname.Length > 64)
            {
                MessageBox.Show("Nicknames cannot be longer than 32 characters.");
                return;
            }

            Int32 iId = DBManager.DB_LookUpUser(strNickname);

            if (iId == -1)
            {
                MessageBox.Show("There is no user registered with this nickname.");
                return;
            }

            User.Login(iId, strNickname);
            MessageBox.Show(
                String.Format("You have successfully logged as {0}!",
                strNickname));

            this.Close();
            retForm.RefreshForm();
            retForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
