using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace โปรแกรมจัดการห้องเรียน
{
    public partial class frm_Housework : Form
    {
        public frm_Housework()
        {
            InitializeComponent();
        }

        private void ออกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Mon1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ManageRoom mngroom = new frm_ManageRoom();
            mngroom.Show();
            this.Hide();
        }
    }
}
