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
    public partial class frm_FirstPage : Form
    {
        public frm_FirstPage()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Developer Dev = new frm_Developer();
            Dev.Show();
            this.Hide();
            Program.CheckClickDev = '1';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmd_login_Click(object sender, EventArgs e)
        {
            frm_SelectRoom selectroom = new frm_SelectRoom();
            selectroom.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
