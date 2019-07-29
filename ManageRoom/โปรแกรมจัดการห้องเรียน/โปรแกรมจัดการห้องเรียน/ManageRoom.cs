using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace โปรแกรมจัดการห้องเรียน
{
    public partial class frm_ManageRoom : Form
    {
        public frm_ManageRoom()
        {
            InitializeComponent();
        }

        private void cmd_LearnTable_Click(object sender, EventArgs e)
        {
            frm_Learntable learntable = new frm_Learntable();
            learntable.Show();
            this.Hide();
        }

        private void cmd_WorkhomeTable_Click(object sender, EventArgs e)
        {
            Program.CheckPress = 2;
            frm_Housework housework = new frm_Housework();
            housework.Show();
            this.Hide();
        }

        private void cmd_UsedClassTable_Click(object sender, EventArgs e)
        {
            frm_Useroomtable urtable = new frm_Useroomtable();
            urtable.Show();
            this.Hide();
        }

        private void cmd_Member_Click(object sender, EventArgs e)
        {
            frm_Studentinroom stdinroom = new frm_Studentinroom();
            stdinroom.Show();
            this.Hide();
        }

        private void ออกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmd_ReportToSupport_Click(object sender, EventArgs e)
        {
            frm_Feedbacktosupport fbtosupp = new frm_Feedbacktosupport();
            fbtosupp.Show();
            this.Hide();
        }
    }
}
