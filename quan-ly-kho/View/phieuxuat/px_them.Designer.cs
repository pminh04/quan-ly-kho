namespace quan_ly_kho.View.phieuxuat
{
    partial class px_them
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tongtienCtpx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuatbtn = new System.Windows.Forms.Button();
            this.khachhangCtpx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.thoigiantaoCtpx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nguoitaoCtpx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maphieuCtpx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.tongtienCtpx);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.xuatbtn);
            this.panel2.Controls.Add(this.khachhangCtpx);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.thoigiantaoCtpx);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nguoitaoCtpx);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.maphieuCtpx);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 478);
            this.panel2.TabIndex = 3;
            // 
            // tongtienCtpx
            // 
            this.tongtienCtpx.Location = new System.Drawing.Point(145, 422);
            this.tongtienCtpx.Name = "tongtienCtpx";
            this.tongtienCtpx.Size = new System.Drawing.Size(241, 22);
            this.tongtienCtpx.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "TỔNG TIỀN:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.masanpham,
            this.tensanpham,
            this.soluong,
            this.dongia,
            this.thanhtien});
            this.dataGridView1.Location = new System.Drawing.Point(16, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(962, 238);
            this.dataGridView1.TabIndex = 10;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.Width = 150;
            // 
            // masanpham
            // 
            this.masanpham.HeaderText = "Mã sản phẩm";
            this.masanpham.MinimumWidth = 8;
            this.masanpham.Name = "masanpham";
            this.masanpham.Width = 150;
            // 
            // tensanpham
            // 
            this.tensanpham.HeaderText = "Tên sản phẩm";
            this.tensanpham.MinimumWidth = 8;
            this.tensanpham.Name = "tensanpham";
            this.tensanpham.Width = 150;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 8;
            this.soluong.Name = "soluong";
            this.soluong.Width = 150;
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.MinimumWidth = 8;
            this.dongia.Name = "dongia";
            this.dongia.Width = 150;
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 8;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Width = 150;
            // 
            // xuatbtn
            // 
            this.xuatbtn.BackColor = System.Drawing.Color.White;
            this.xuatbtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatbtn.ForeColor = System.Drawing.Color.Black;
            this.xuatbtn.Image = global::quan_ly_kho.Properties.Resources.icons8_pdf_50;
            this.xuatbtn.Location = new System.Drawing.Point(781, 395);
            this.xuatbtn.Name = "xuatbtn";
            this.xuatbtn.Size = new System.Drawing.Size(146, 47);
            this.xuatbtn.TabIndex = 9;
            this.xuatbtn.Text = "Xuất PDF";
            this.xuatbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xuatbtn.UseVisualStyleBackColor = false;
            // 
            // khachhangCtpx
            // 
            this.khachhangCtpx.Location = new System.Drawing.Point(641, 25);
            this.khachhangCtpx.Name = "khachhangCtpx";
            this.khachhangCtpx.Size = new System.Drawing.Size(299, 22);
            this.khachhangCtpx.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Thời gian tạo:";
            // 
            // thoigiantaoCtpx
            // 
            this.thoigiantaoCtpx.Location = new System.Drawing.Point(641, 62);
            this.thoigiantaoCtpx.Name = "thoigiantaoCtpx";
            this.thoigiantaoCtpx.Size = new System.Drawing.Size(299, 22);
            this.thoigiantaoCtpx.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Khách hàng:";
            // 
            // nguoitaoCtpx
            // 
            this.nguoitaoCtpx.Location = new System.Drawing.Point(115, 61);
            this.nguoitaoCtpx.Name = "nguoitaoCtpx";
            this.nguoitaoCtpx.Size = new System.Drawing.Size(299, 22);
            this.nguoitaoCtpx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Người tạo:";
            // 
            // maphieuCtpx
            // 
            this.maphieuCtpx.Location = new System.Drawing.Point(115, 23);
            this.maphieuCtpx.Name = "maphieuCtpx";
            this.maphieuCtpx.Size = new System.Drawing.Size(299, 22);
            this.maphieuCtpx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 95);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết phiếu xuất";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // px_them
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "px_them";
            this.Text = "px_them";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button xuatbtn;
        private System.Windows.Forms.TextBox khachhangCtpx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox thoigiantaoCtpx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nguoitaoCtpx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maphieuCtpx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tongtienCtpx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn masanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}