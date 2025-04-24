namespace quan_ly_kho.View
{
    partial class log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minp = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.closep = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginpart = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.quenmk = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.dangnhapp = new System.Windows.Forms.Panel();
            this.dangnhap = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.minp.SuspendLayout();
            this.closep.SuspendLayout();
            this.img.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginpart.SuspendLayout();
            this.dangnhapp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.minp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.closep);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 43);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // minp
            // 
            this.minp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minp.BackColor = System.Drawing.SystemColors.Window;
            this.minp.Controls.Add(this.minimize);
            this.minp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minp.Location = new System.Drawing.Point(1000, 1);
            this.minp.Name = "minp";
            this.minp.Size = new System.Drawing.Size(37, 38);
            this.minp.TabIndex = 4;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Green;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(-14, -10);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(64, 54);
            this.minimize.TabIndex = 0;
            this.minimize.Text = "-";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý kho vật tư";
            // 
            // closep
            // 
            this.closep.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closep.BackColor = System.Drawing.SystemColors.Window;
            this.closep.Controls.Add(this.close);
            this.closep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closep.Location = new System.Drawing.Point(1043, 1);
            this.closep.Name = "closep";
            this.closep.Size = new System.Drawing.Size(37, 38);
            this.closep.TabIndex = 1;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Green;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(-14, -10);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(64, 54);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // img
            // 
            this.img.BackColor = System.Drawing.Color.Green;
            this.img.Controls.Add(this.label2);
            this.img.Controls.Add(this.pictureBox1);
            this.img.Location = new System.Drawing.Point(17, 67);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(554, 459);
            this.img.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(117, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản lý kho vật tư";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginpart
            // 
            this.loginpart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.loginpart.Controls.Add(this.label8);
            this.loginpart.Controls.Add(this.quenmk);
            this.loginpart.Controls.Add(this.txtmk);
            this.loginpart.Controls.Add(this.txttk);
            this.loginpart.Controls.Add(this.dangnhapp);
            this.loginpart.Controls.Add(this.label6);
            this.loginpart.Controls.Add(this.label5);
            this.loginpart.Controls.Add(this.label4);
            this.loginpart.Controls.Add(this.label3);
            this.loginpart.Location = new System.Drawing.Point(567, 67);
            this.loginpart.Name = "loginpart";
            this.loginpart.Size = new System.Drawing.Size(506, 459);
            this.loginpart.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(57, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(413, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Lưu ý: Nếu chưa có tài khoản hay liên hệ với admin";
            // 
            // quenmk
            // 
            this.quenmk.AutoSize = true;
            this.quenmk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.quenmk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quenmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quenmk.ForeColor = System.Drawing.Color.Black;
            this.quenmk.Location = new System.Drawing.Point(312, 267);
            this.quenmk.Name = "quenmk";
            this.quenmk.Size = new System.Drawing.Size(138, 23);
            this.quenmk.TabIndex = 9;
            this.quenmk.Text = "Quên mật khẩu";
            // 
            // txtmk
            // 
            this.txtmk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmk.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Location = new System.Drawing.Point(188, 230);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '●';
            this.txtmk.Size = new System.Drawing.Size(262, 27);
            this.txtmk.TabIndex = 8;
            // 
            // txttk
            // 
            this.txttk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttk.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttk.Location = new System.Drawing.Point(188, 156);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(262, 27);
            this.txttk.TabIndex = 7;
            // 
            // dangnhapp
            // 
            this.dangnhapp.Controls.Add(this.dangnhap);
            this.dangnhapp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dangnhapp.Location = new System.Drawing.Point(188, 324);
            this.dangnhapp.Name = "dangnhapp";
            this.dangnhapp.Size = new System.Drawing.Size(148, 43);
            this.dangnhapp.TabIndex = 6;
            // 
            // dangnhap
            // 
            this.dangnhap.BackColor = System.Drawing.Color.Green;
            this.dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap.ForeColor = System.Drawing.SystemColors.Control;
            this.dangnhap.Location = new System.Drawing.Point(-34, -30);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(215, 102);
            this.dangnhap.TabIndex = 7;
            this.dangnhap.Text = "Đăng nhập";
            this.dangnhap.UseVisualStyleBackColor = false;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(35, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(167, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(224)))), ((int)(((byte)(206)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xin chào!";
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1089, 540);
            this.Controls.Add(this.loginpart);
            this.Controls.Add(this.img);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "log";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.minp.ResumeLayout(false);
            this.closep.ResumeLayout(false);
            this.img.ResumeLayout(false);
            this.img.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginpart.ResumeLayout(false);
            this.loginpart.PerformLayout();
            this.dangnhapp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel closep;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel minp;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Panel img;
        private System.Windows.Forms.Panel loginpart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Panel dangnhapp;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label quenmk;
        private System.Windows.Forms.Label label8;
    }
}