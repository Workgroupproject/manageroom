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
    public partial class frm_Developer : Form
    {
        public frm_Developer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Program.CheckClickDev == '1')
            {
                frm_FirstPage firstpage = new frm_FirstPage();
                firstpage.Show();
                this.Hide();
            }
            if(Program.CheckClickDev == '2')
            {
                frm_SelectRoom selectroom = new frm_SelectRoom();
                selectroom.Show();
                this.Hide();
            }
            
        }
    }
}
