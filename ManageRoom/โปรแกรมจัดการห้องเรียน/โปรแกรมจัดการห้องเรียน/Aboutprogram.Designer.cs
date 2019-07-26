namespace โปรแกรมจัดการห้องเรียน
{
    partial class frm_Aboutprogram
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_whatsnew = new System.Windows.Forms.Panel();
            this.lbl_whatsnew = new System.Windows.Forms.Label();
            this.lbl_ProgramName = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_Copyright = new System.Windows.Forms.Label();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.cmd_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_whatsnew.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::โปรแกรมจัดการห้องเรียน.Properties.Resources._46441678_2262897190653988_2669579597623853056_o__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(28, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 390);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_whatsnew
            // 
            this.pnl_whatsnew.AutoScroll = true;
            this.pnl_whatsnew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_whatsnew.Controls.Add(this.lbl_whatsnew);
            this.pnl_whatsnew.Location = new System.Drawing.Point(229, 233);
            this.pnl_whatsnew.Name = "pnl_whatsnew";
            this.pnl_whatsnew.Size = new System.Drawing.Size(307, 174);
            this.pnl_whatsnew.TabIndex = 1;
            // 
            // lbl_whatsnew
            // 
            this.lbl_whatsnew.Location = new System.Drawing.Point(17, 18);
            this.lbl_whatsnew.Name = "lbl_whatsnew";
            this.lbl_whatsnew.Size = new System.Drawing.Size(267, 153);
            this.lbl_whatsnew.TabIndex = 0;
            this.lbl_whatsnew.Text = "อัพเดทเวอร์ชั่น 0.1\r\n       -สามารถเข้าหน้าจัดการได้\r\nอัพเดทเวอร์ชั่น 0.25\r\n     " +
    "    -เพิ่มหน้าตารางเรียน\r\n";
            // 
            // lbl_ProgramName
            // 
            this.lbl_ProgramName.AutoSize = true;
            this.lbl_ProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_ProgramName.Location = new System.Drawing.Point(225, 33);
            this.lbl_ProgramName.Name = "lbl_ProgramName";
            this.lbl_ProgramName.Size = new System.Drawing.Size(180, 20);
            this.lbl_ProgramName.TabIndex = 2;
            this.lbl_ProgramName.Text = "โปรแกรมจัดการห้องเรียน";
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Version.Location = new System.Drawing.Point(225, 87);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(96, 20);
            this.lbl_Version.TabIndex = 3;
            this.lbl_Version.Text = "เวอร์ชั่น 0.25";
            // 
            // lbl_Copyright
            // 
            this.lbl_Copyright.AutoSize = true;
            this.lbl_Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Copyright.Location = new System.Drawing.Point(225, 142);
            this.lbl_Copyright.Name = "lbl_Copyright";
            this.lbl_Copyright.Size = new System.Drawing.Size(151, 20);
            this.lbl_Copyright.TabIndex = 4;
            this.lbl_Copyright.Text = "c กลุ่ม 9 ม.3/3 2562";
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Company.Location = new System.Drawing.Point(225, 197);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(277, 20);
            this.lbl_Company.TabIndex = 5;
            this.lbl_Company.Text = "โรงเรียนกาญจนาภิเษกวิทยาลัย นครปฐม";
            this.lbl_Company.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmd_OK
            // 
            this.cmd_OK.Location = new System.Drawing.Point(455, 437);
            this.cmd_OK.Name = "cmd_OK";
            this.cmd_OK.Size = new System.Drawing.Size(98, 33);
            this.cmd_OK.TabIndex = 6;
            this.cmd_OK.Text = "โอเค";
            this.cmd_OK.UseVisualStyleBackColor = true;
            this.cmd_OK.Click += new System.EventHandler(this.cmd_OK_Click);
            // 
            // frm_Aboutprogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 484);
            this.Controls.Add(this.cmd_OK);
            this.Controls.Add(this.lbl_Company);
            this.Controls.Add(this.lbl_Copyright);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.lbl_ProgramName);
            this.Controls.Add(this.pnl_whatsnew);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_Aboutprogram";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Aboutprogram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_whatsnew.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_whatsnew;
        private System.Windows.Forms.Label lbl_whatsnew;
        private System.Windows.Forms.Label lbl_ProgramName;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lbl_Copyright;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.Button cmd_OK;
    }
}