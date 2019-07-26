﻿using System;
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
            frm_Housework housework = new frm_Housework();
            housework.Show();
            this.Hide();
        }
    }
}
