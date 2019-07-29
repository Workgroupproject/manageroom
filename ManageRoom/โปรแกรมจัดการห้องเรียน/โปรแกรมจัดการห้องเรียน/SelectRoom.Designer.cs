namespace โปรแกรมจัดการห้องเรียน
{
    partial class frm_SelectRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_import = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_language = new System.Windows.Forms.ToolStripMenuItem();
            this.lang_thai = new System.Windows.Forms.ToolStripMenuItem();
            this.lang_eng = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_aboutprogram = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_contact = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_developer = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.cmd_Room3 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmd_Room2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmd_Room1 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.มธยมศกษาปท3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.มธยมศกษาปท4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Warning = new System.Windows.Forms.Label();
            this.cmd_Accept = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_setting,
            this.menu_about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_import,
            this.menu_exit});
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(45, 24);
            this.menu_file.Text = "ไฟล์";
            this.menu_file.Click += new System.EventHandler(this.menu_file_Click);
            // 
            // menu_import
            // 
            this.menu_import.Name = "menu_import";
            this.menu_import.Size = new System.Drawing.Size(181, 26);
            this.menu_import.Text = "นำเข้า";
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(181, 26);
            this.menu_exit.Text = "ออก";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // menu_setting
            // 
            this.menu_setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_language});
            this.menu_setting.Name = "menu_setting";
            this.menu_setting.Size = new System.Drawing.Size(52, 24);
            this.menu_setting.Text = "ตั้งค่า";
            // 
            // menu_language
            // 
            this.menu_language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lang_thai,
            this.lang_eng});
            this.menu_language.Name = "menu_language";
            this.menu_language.Size = new System.Drawing.Size(116, 26);
            this.menu_language.Text = "ภาษา";
            // 
            // lang_thai
            // 
            this.lang_thai.Name = "lang_thai";
            this.lang_thai.Size = new System.Drawing.Size(139, 26);
            this.lang_thai.Text = "ภาษาไทย";
            this.lang_thai.Click += new System.EventHandler(this.lang_thai_Click);
            // 
            // lang_eng
            // 
            this.lang_eng.Name = "lang_eng";
            this.lang_eng.Size = new System.Drawing.Size(139, 26);
            this.lang_eng.Text = "English";
            this.lang_eng.Click += new System.EventHandler(this.lang_eng_Click);
            // 
            // menu_about
            // 
            this.menu_about.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_aboutprogram,
            this.menu_contact,
            this.menu_developer});
            this.menu_about.Name = "menu_about";
            this.menu_about.Size = new System.Drawing.Size(67, 24);
            this.menu_about.Text = "เกี่ยวกับ";
            this.menu_about.Click += new System.EventHandler(this.menu_about_Click);
            // 
            // menu_aboutprogram
            // 
            this.menu_aboutprogram.Name = "menu_aboutprogram";
            this.menu_aboutprogram.Size = new System.Drawing.Size(179, 26);
            this.menu_aboutprogram.Text = "เกี่ยวกับโปรแกรม";
            this.menu_aboutprogram.Click += new System.EventHandler(this.menu_version_Click);
            // 
            // menu_contact
            // 
            this.menu_contact.Name = "menu_contact";
            this.menu_contact.Size = new System.Drawing.Size(179, 26);
            this.menu_contact.Text = "วิธีการติดต่อ";
            this.menu_contact.Click += new System.EventHandler(this.menu_contact_Click);
            // 
            // menu_developer
            // 
            this.menu_developer.Name = "menu_developer";
            this.menu_developer.Size = new System.Drawing.Size(179, 26);
            this.menu_developer.Text = "คณะผู้จัดทำ";
            this.menu_developer.Click += new System.EventHandler(this.menu_developer_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.cmd_Room3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.cmd_Room2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cmd_Room1);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Location = new System.Drawing.Point(94, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 380);
            this.panel1.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("TH SarabunPSK", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button5.Location = new System.Drawing.Point(707, 329);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(238, 240);
            this.button5.TabIndex = 5;
            this.button5.Text = "ห้อง 6";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cmd_Room3
            // 
            this.cmd_Room3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmd_Room3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_Room3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Room3.Font = new System.Drawing.Font("TH SarabunPSK", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cmd_Room3.Location = new System.Drawing.Point(707, 43);
            this.cmd_Room3.Name = "cmd_Room3";
            this.cmd_Room3.Size = new System.Drawing.Size(238, 240);
            this.cmd_Room3.TabIndex = 4;
            this.cmd_Room3.Text = "ห้อง 3";
            this.cmd_Room3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmd_Room3.UseVisualStyleBackColor = false;
            this.cmd_Room3.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("TH SarabunPSK", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button3.Location = new System.Drawing.Point(385, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 240);
            this.button3.TabIndex = 3;
            this.button3.Text = "ห้อง 5";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmd_Room2
            // 
            this.cmd_Room2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmd_Room2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_Room2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Room2.Font = new System.Drawing.Font("TH SarabunPSK", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cmd_Room2.Location = new System.Drawing.Point(385, 43);
            this.cmd_Room2.Name = "cmd_Room2";
            this.cmd_Room2.Size = new System.Drawing.Size(238, 240);
            this.cmd_Room2.TabIndex = 2;
            this.cmd_Room2.Text = "ห้อง 2";
            this.cmd_Room2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmd_Room2.UseVisualStyleBackColor = false;
            this.cmd_Room2.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("TH SarabunPSK", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(55, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 240);
            this.button2.TabIndex = 1;
            this.button2.Text = "ห้อง 4";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmd_Room1
            // 
            this.cmd_Room1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmd_Room1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_Room1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Room1.Font = new System.Drawing.Font("TH SarabunPSK", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cmd_Room1.Location = new System.Drawing.Point(55, 43);
            this.cmd_Room1.Name = "cmd_Room1";
            this.cmd_Room1.Size = new System.Drawing.Size(238, 240);
            this.cmd_Room1.TabIndex = 0;
            this.cmd_Room1.Text = "ห้อง 1";
            this.cmd_Room1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmd_Room1.UseVisualStyleBackColor = false;
            this.cmd_Room1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.มธยมศกษาปท3ToolStripMenuItem,
            this.มธยมศกษาปท4ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1015, 28);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // มธยมศกษาปท3ToolStripMenuItem
            // 
            this.มธยมศกษาปท3ToolStripMenuItem.Name = "มธยมศกษาปท3ToolStripMenuItem";
            this.มธยมศกษาปท3ToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.มธยมศกษาปท3ToolStripMenuItem.Text = "มัธยมศึกษาปีที่ 3";
            // 
            // มธยมศกษาปท4ToolStripMenuItem
            // 
            this.มธยมศกษาปท4ToolStripMenuItem.Name = "มธยมศกษาปท4ToolStripMenuItem";
            this.มธยมศกษาปท4ToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.มธยมศกษาปท4ToolStripMenuItem.Text = "มัธยมศึกษาปีที่ 4";
            // 
            // lbl_Warning
            // 
            this.lbl_Warning.AutoSize = true;
            this.lbl_Warning.Font = new System.Drawing.Font("TH SarabunPSK", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Warning.ForeColor = System.Drawing.Color.Red;
            this.lbl_Warning.Location = new System.Drawing.Point(142, 537);
            this.lbl_Warning.Name = "lbl_Warning";
            this.lbl_Warning.Size = new System.Drawing.Size(329, 38);
            this.lbl_Warning.TabIndex = 11;
            this.lbl_Warning.Text = "**กรุณาเลือกห้องเรียนที่ใช้เท่านั้น";
            // 
            // cmd_Accept
            // 
            this.cmd_Accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmd_Accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_Accept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmd_Accept.FlatAppearance.BorderSize = 3;
            this.cmd_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_Accept.Font = new System.Drawing.Font("TH SarabunPSK", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cmd_Accept.Location = new System.Drawing.Point(1085, 606);
            this.cmd_Accept.Name = "cmd_Accept";
            this.cmd_Accept.Size = new System.Drawing.Size(132, 43);
            this.cmd_Accept.TabIndex = 12;
            this.cmd_Accept.Text = "ยืนยัน";
            this.cmd_Accept.UseVisualStyleBackColor = false;
            this.cmd_Accept.Click += new System.EventHandler(this.cmd_Accept_Click);
            // 
            // frm_SelectRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.cmd_Accept);
            this.Controls.Add(this.lbl_Warning);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_SelectRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมจัดการห้องเรียน-เลือกห้อง";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.Shown += new System.EventHandler(this.frm_SelectRoom_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_file;
        private System.Windows.Forms.ToolStripMenuItem menu_import;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_setting;
        private System.Windows.Forms.ToolStripMenuItem menu_language;
        private System.Windows.Forms.ToolStripMenuItem menu_about;
        private System.Windows.Forms.ToolStripMenuItem menu_aboutprogram;
        private System.Windows.Forms.ToolStripMenuItem menu_contact;
        private System.Windows.Forms.ToolStripMenuItem menu_developer;
        private System.Windows.Forms.ToolStripMenuItem lang_thai;
        private System.Windows.Forms.ToolStripMenuItem lang_eng;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmd_Room1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button cmd_Room3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cmd_Room2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem มธยมศกษาปท3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem มธยมศกษาปท4ToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Warning;
        private System.Windows.Forms.Button cmd_Accept;
    }
}