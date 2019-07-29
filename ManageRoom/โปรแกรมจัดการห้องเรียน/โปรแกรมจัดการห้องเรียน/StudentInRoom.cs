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
    public partial class frm_Studentinroom : Form
    {
        public frm_Studentinroom()
        {
            InitializeComponent();
        }

        private void cmd_Back_Click(object sender, EventArgs e)
        {
            frm_ManageRoom mngroom = new frm_ManageRoom();
            mngroom.Show();
            this.Hide();
        }

        private void ออกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
