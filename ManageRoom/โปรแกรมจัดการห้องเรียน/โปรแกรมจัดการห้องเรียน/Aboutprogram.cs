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
    public partial class frm_Aboutprogram : Form
    {
        public frm_Aboutprogram()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmd_OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Aboutprogram_Load(object sender, EventArgs e)
        {
            if(Program.language == "English")
            {
                cmd_OK.Text = "OK";
                lbl_ProgramName.Text = "Classroom Manager";
                lbl_Version.Text = "V 0.1";
                lbl_Copyright.Text = "Copyright 2019 Kanjanapisek witthayalai nakhonpathom";
                lbl_Company.Text = "M.3/3 Group 9 2019";
            }
            if (Program.language == "Thai")
            {
                cmd_OK.Text = "โอเค";
                lbl_ProgramName.Text = "โปรแกรมจัดการห้องเรียน";
                lbl_Version.Text = "เวอร์ชั่น 0.1";
                lbl_Copyright.Text = "2019 กาญจนาภืเษกวิทยาลัย นครปฐม";
                lbl_Company.Text = "ม.3/3 กลุ่ม 9 ปี62";
            }
        }
    }
}
