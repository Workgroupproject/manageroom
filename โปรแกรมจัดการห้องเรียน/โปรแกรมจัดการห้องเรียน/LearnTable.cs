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
    public partial class frm_Learntable : Form
    {
        public frm_Learntable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ManageRoom mngroom = new frm_ManageRoom();
            mngroom.Show();
            this.Hide();
        }

        private void cmd_Changedata_Click(object sender, EventArgs e)
        {
            cmd_Savedata.Visible = true;
            cmd_Changedata.Visible = false;
            cmd_Changedata.Text = "บันทึกการเปลี่ยนแปลง";
            txt_Mon1.ReadOnly = false;
            txt_Mon2.ReadOnly = false;
            txt_Mon3.ReadOnly = false;
            txt_Mon4.ReadOnly = false;
            txt_Mon5.ReadOnly = false;
            txt_Mon6.ReadOnly = false;
            txt_Mon7.ReadOnly = false;
            txt_Mon8.ReadOnly = false;
            txt_Mon9.ReadOnly = false;
            txt_Mon10.ReadOnly = false;
            txt_Tue1.ReadOnly = false;
            txt_Tue2.ReadOnly = false;
            txt_Tue3.ReadOnly = false;
            txt_Tue4.ReadOnly = false;
            txt_Tue5.ReadOnly = false;
            txt_Tue7.ReadOnly = false;
            txt_Tue8.ReadOnly = false;
            txt_Tue9.ReadOnly = false;
            txt_Tue10.ReadOnly = false;
            txt_Wed1.ReadOnly = false;
            txt_Wed2.ReadOnly = false;
            txt_Wed3.ReadOnly = false;
            txt_Wed4.ReadOnly = false;
            txt_Wed5.ReadOnly = false;
            txt_Wed6.ReadOnly = false;
            txt_Wed7.ReadOnly = false;
            txt_Wed8.ReadOnly = false;
            txt_Wed9.ReadOnly = false;
            txt_Wed10.ReadOnly = false;
            txt_Thu1.ReadOnly = false;
            txt_Thu2.ReadOnly = false;
            txt_Thu3.ReadOnly = false;
            txt_Thu4.ReadOnly = false;
            txt_Thu5.ReadOnly = false;
            txt_Thu6.ReadOnly = false;
            txt_Thu7.ReadOnly = false;
            txt_Thu8.ReadOnly = false;
            txt_Thu9.ReadOnly = false;
            txt_Thu10.ReadOnly = false;
            txt_Fri1.ReadOnly = false;
            txt_Fri2.ReadOnly = false;
            txt_Fri3.ReadOnly = false;
            txt_Fri4.ReadOnly = false;
            txt_Fri5.ReadOnly = false;
            txt_Fri6.ReadOnly = false;
            txt_Fri7.ReadOnly = false;
            txt_Fri8.ReadOnly = false;
            txt_Fri9.ReadOnly = false;
            txt_Fri10.ReadOnly = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd_Changedata.Visible = true;
            cmd_Savedata.Visible = false;
            txt_Mon1.ReadOnly = true;
            txt_Mon2.ReadOnly = true;
            txt_Mon3.ReadOnly = true;
            txt_Mon4.ReadOnly = true;
            txt_Mon5.ReadOnly = true;
            txt_Mon6.ReadOnly = true;
            txt_Mon7.ReadOnly = true;
            txt_Mon8.ReadOnly = true;
            txt_Mon9.ReadOnly = true;
            txt_Mon10.ReadOnly = true;
            txt_Tue1.ReadOnly = true;
            txt_Tue2.ReadOnly = true;
            txt_Tue3.ReadOnly = true;
            txt_Tue4.ReadOnly = true;
            txt_Tue5.ReadOnly = true;
            txt_Tue7.ReadOnly = true;
            txt_Tue8.ReadOnly = true;
            txt_Tue9.ReadOnly = true;
            txt_Tue10.ReadOnly = true;
            txt_Wed1.ReadOnly = true;
            txt_Wed2.ReadOnly = true;
            txt_Wed3.ReadOnly = true;
            txt_Wed4.ReadOnly = true;
            txt_Wed5.ReadOnly = true;
            txt_Wed6.ReadOnly = true;
            txt_Wed7.ReadOnly = true;
            txt_Wed8.ReadOnly = true;
            txt_Wed9.ReadOnly = true;
            txt_Wed10.ReadOnly = true;
            txt_Thu1.ReadOnly = true;
            txt_Thu2.ReadOnly = true;
            txt_Thu3.ReadOnly = true;
            txt_Thu4.ReadOnly = true;
            txt_Thu5.ReadOnly = true;
            txt_Thu6.ReadOnly = true;
            txt_Thu7.ReadOnly = true;
            txt_Thu8.ReadOnly = true;
            txt_Thu9.ReadOnly = true;
            txt_Thu10.ReadOnly = true;
            txt_Fri1.ReadOnly = true;
            txt_Fri2.ReadOnly = true;
            txt_Fri3.ReadOnly = true;
            txt_Fri4.ReadOnly = true;
            txt_Fri5.ReadOnly = true;
            txt_Fri6.ReadOnly = true;
            txt_Fri7.ReadOnly = true;
            txt_Fri8.ReadOnly = true;
            txt_Fri9.ReadOnly = true;
            txt_Fri10.ReadOnly = true;
        }

        private void ออกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_Learntable_Shown(object sender, EventArgs e)
        {
            String sql = " SELECT * FROM Student";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JS7HVA0\MYSERVER;Initial Catalog=Student;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_Mon1.Text = (dr["Name"].ToString());
                txt_Mon2.Text = (dr["Grade"].ToString());
                txt_Mon3.Text = (dr["Room"].ToString());
            }
            con.Close();
        }

        private void txt_Mon1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    /*String source = @"Data Source=DESKTOP-JS7HVA0\MYSERVER;Initial Catalog=Student;Integrated Security=True";
    SqlConnection con = new SqlConnection(source);
    con.Open();

            String sqlselectQuery = "SELECT * FROM Student WHERE Name =";
    SqlCommand cmd = new SqlCommand(sqlselectQuery, con);
    SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
           {
                txt_Mon1.Text = (dr["Name"].ToString());
               txt_Mon2.Text = (dr["Grade"].ToString());
             
            con.Close();
        }
txt_Mon3.Text = (dr["Room"].ToString());
            }*/
