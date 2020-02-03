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
    public partial class RegisterForm : Form
    {
        private MainForm retForm = null;
        public RegisterForm(MainForm mForm)
        {
            retForm = mForm;
            InitializeComponent();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Task Management System\nVersion 0.0.1 alpha\nDaniel Bodurov\n");
        }

        private void FinishRegLabel_Click(object sender, EventArgs e)
        {
            if (NicknameTextBox == null)
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

            if (strNickname.Length > 32)
            {
                MessageBox.Show("Nicknames cannot be longer than 32 characters.");
                return;
            }

            Int32 iId = DBManager.DB_LookUpUser(strNickname);

            if (iId != -1)
            {
                MessageBox.Show("A user with this Nickname already exists!\nTry again with another Nickname...");
                return;
            }

            DBManager.DB_RegisterUser(strNickname);
            MessageBox.Show(
                String.Format("You have successfully registered as {0}!\nYou will be automatically logged in!",
                strNickname));

            iId = DBManager.DB_LookUpUser(strNickname);
            User.Login(iId, strNickname);

            this.Close();
            retForm.RefreshForm();
            retForm.Show();
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
    }
}
