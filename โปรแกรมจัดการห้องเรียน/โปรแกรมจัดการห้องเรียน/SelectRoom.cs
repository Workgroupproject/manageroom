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
    public partial class frm_SelectRoom : Form
    {
        
        public frm_SelectRoom()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lang_thai_Click(object sender, EventArgs e)
        {
            Program.language = "Thai";
            if (Program.language == "Thai")
            {
                menu_file.Text = "ไฟล์";
                menu_import.Text = "นำเข้า";
                menu_exit.Text = "ออก";
                menu_setting.Text = "ตั้งค่า";
                menu_language.Text = "ภาษา";
                lang_thai.Text = "ภาษาไทย";
                lang_eng.Text = "ภาษาอังกฤษ";
                menu_about.Text = "เกี่ยวกับ";
                menu_aboutprogram.Text = "เกี่ยวกับโปรแกรม";
                menu_contact.Text = "วิธีการติดต่อ";
                menu_developer.Text = "คณะผู้จัดทำ";
            }
        }

        private void menu_version_Click(object sender, EventArgs e)
        {
            frm_Aboutprogram aboutprogram = new frm_Aboutprogram();
            aboutprogram.Show();
        }

        private void menu_whatsnew_Click(object sender, EventArgs e)
        {

        }

        private void lang_eng_Click(object sender, EventArgs e)
        {
            Program.language = "English";
            if (Program.language == "English")
            {
                menu_file.Text = "File";
                menu_import.Text = "Import";
                menu_exit.Text = "Exit";
                menu_setting.Text = "Setting";
                menu_language.Text = "Language";
                lang_thai.Text = "Thai";
                lang_eng.Text = "English";
                menu_about.Text = "About";
                menu_aboutprogram.Text = "About";
                menu_contact.Text = "Contact";
                menu_developer.Text = "Developer";

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menu_file_Click(object sender, EventArgs e)
        {

        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            
            
        }

        private void menu_about_Click(object sender, EventArgs e)
        {

        }

        private void menu_contact_Click(object sender, EventArgs e)
        {
           
        }

        private void menu_developer_Click(object sender, EventArgs e)
        {
            Program.CheckClickDev = '2';
            frm_Developer dev = new frm_Developer();
            dev.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.Room = '2';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.Room = '3';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Room = '1';
        }

        private void cmd_Accept_Click(object sender, EventArgs e)
        {
            DialogResult CheckYes = MessageBox.Show("คุณแน่ใจหรือไม่ว่าจะเลือกห้องเรียนนี้?", "คำเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CheckYes == DialogResult.Yes)
            {
                frm_ManageRoom mngroom = new frm_ManageRoom();
                mngroom.Show();
                this.Hide();
            }
            
        }

        private void frm_SelectRoom_Shown(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Room = '4';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.Room = '5';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.Room = '6';
        }
    }
}
