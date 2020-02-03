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
    public partial class CalendarForm : Form
    {
        private DateTime m_Date;
        public CalendarForm(ref DateTime date)
        {
            m_Date = date;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_Date = dateTimePicker.Value;
            this.Close();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Today;
        }
    }
}
