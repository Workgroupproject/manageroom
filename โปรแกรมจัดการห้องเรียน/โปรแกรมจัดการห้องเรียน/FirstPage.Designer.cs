namespace โปรแกรมจัดการห้องเรียน
{
    partial class frm_FirstPage
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
            this.lbl_Projname = new System.Windows.Forms.Label();
            this.cmd_login = new System.Windows.Forms.Button();
            this.cmd_dev = new System.Windows.Forms.Button();
            this.img_exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Projname
            // 
            this.lbl_Projname.Font = new System.Drawing.Font("TH Sarabun New", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbl_Projname.Location = new System.Drawing.Point(47, 86);
            this.lbl_Projname.Name = "lbl_Projname";
            this.lbl_Projname.Size = new System.Drawing.Size(688, 89);
            this.lbl_Projname.TabIndex = 3;
            this.lbl_Projname.Text = "โปรแกรมจัดการห้องเรียน";
            this.lbl_Projname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmd_login
            // 
            this.cmd_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmd_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmd_login.FlatAppearance.BorderSize = 3;
            this.cmd_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cmd_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_login.Location = new System.Drawing.Point(66, 331);
            this.cmd_login.Name = "cmd_login";
            this.cmd_login.Size = new System.Drawing.Size(264, 92);
            this.cmd_login.TabIndex = 4;
            this.cmd_login.Text = "เข้าสู่โปรแกรม";
            this.cmd_login.UseVisualStyleBackColor = false;
            this.cmd_login.Click += new System.EventHandler(this.cmd_login_Click);
            // 
            // cmd_dev
            // 
            this.cmd_dev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmd_dev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmd_dev.FlatAppearance.BorderSize = 3;
            this.cmd_dev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cmd_dev.Location = new System.Drawing.Point(434, 331);
            this.cmd_dev.Name = "cmd_dev";
            this.cmd_dev.Size = new System.Drawing.Size(264, 92);
            this.cmd_dev.TabIndex = 5;
            this.cmd_dev.Text = "คณะผู้จัดทำ";
            this.cmd_dev.UseVisualStyleBackColor = false;
            this.cmd_dev.Click += new System.EventHandler(this.button2_Click);
            // 
            // img_exit
            // 
            this.img_exit.Image = global::โปรแกรมจัดการห้องเรียน.Properties.Resources.W95MBX01;
            this.img_exit.Location = new System.Drawing.Point(1112, 554);
            this.img_exit.Name = "img_exit";
            this.img_exit.Size = new System.Drawing.Size(105, 100);
            this.img_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_exit.TabIndex = 6;
            this.img_exit.TabStop = false;
            this.img_exit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::โปรแกรมจัดการห้องเรียน.Properties.Resources.W95MBX01;
            this.pictureBox1.Location = new System.Drawing.Point(680, 470);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // frm_FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.img_exit);
            this.Controls.Add(this.cmd_dev);
            this.Controls.Add(this.cmd_login);
            this.Controls.Add(this.lbl_Projname);
            this.Name = "frm_FirstPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมจัดการห้องเรียน-หน้าต้อนรับ";
            ((System.ComponentModel.ISupportInitialize)(this.img_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Projname;
        private System.Windows.Forms.Button cmd_login;
        private System.Windows.Forms.Button cmd_dev;
        private System.Windows.Forms.PictureBox img_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

