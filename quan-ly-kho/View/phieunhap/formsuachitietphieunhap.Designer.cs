namespace quan_ly_kho.View.phieunhap
{
    partial class formsuachitietphieunhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formsuachitietphieunhap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnguoitao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxnhacungcap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tablenhaphang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tablesanpham = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtmaphieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablenhaphang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesanpham)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // tongtien
            // 
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            this.tongtien.Width = 125;
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.MinimumWidth = 6;
            this.dongia.Name = "dongia";
            this.dongia.Width = 125;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 125;
            // 
            // masanpham
            // 
            this.masanpham.HeaderText = "Mã sản phẩm";
            this.masanpham.MinimumWidth = 6;
            this.masanpham.Name = "masanpham";
            this.masanpham.Width = 125;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 99;
            // 
            // txtnguoitao
            // 
            this.txtnguoitao.Enabled = false;
            this.txtnguoitao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtnguoitao.Location = new System.Drawing.Point(192, 143);
            this.txtnguoitao.Name = "txtnguoitao";
            this.txtnguoitao.Size = new System.Drawing.Size(300, 27);
            this.txtnguoitao.TabIndex = 12;
            this.txtnguoitao.TextChanged += new System.EventHandler(this.txtnguoitao_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(14, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Người tạo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbxnhacungcap
            // 
            this.cbxnhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxnhacungcap.FormattingEnabled = true;
            this.cbxnhacungcap.Location = new System.Drawing.Point(192, 101);
            this.cbxnhacungcap.Name = "cbxnhacungcap";
            this.cbxnhacungcap.Size = new System.Drawing.Size(300, 28);
            this.cbxnhacungcap.TabIndex = 10;
            this.cbxnhacungcap.SelectedIndexChanged += new System.EventHandler(this.cbxnhacungcap_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(14, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nhà cung cấp";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.Color.Green;
            this.btncapnhat.FlatAppearance.BorderSize = 0;
            this.btncapnhat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btncapnhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncapnhat.ForeColor = System.Drawing.Color.White;
            this.btncapnhat.Location = new System.Drawing.Point(297, 700);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(109, 38);
            this.btncapnhat.TabIndex = 5;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách sản phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(135, 709);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(125, 22);
            this.txttongtien.TabIndex = 7;
            this.txttongtien.TextChanged += new System.EventHandler(this.txttongtien_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(32, 711);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng tiền";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "timkiem.png");
            this.imageList1.Images.SetKeyName(1, "xoa.png");
            // 
            // tablenhaphang
            // 
            this.tablenhaphang.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablenhaphang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablenhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablenhaphang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.masanpham,
            this.soluong,
            this.dongia,
            this.tongtien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablenhaphang.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablenhaphang.EnableHeadersVisualStyles = false;
            this.tablenhaphang.Location = new System.Drawing.Point(21, 185);
            this.tablenhaphang.Name = "tablenhaphang";
            this.tablenhaphang.RowHeadersWidth = 51;
            this.tablenhaphang.RowTemplate.Height = 24;
            this.tablenhaphang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablenhaphang.Size = new System.Drawing.Size(556, 501);
            this.tablenhaphang.TabIndex = 3;
            this.tablenhaphang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablenhaphang_CellClick);
            this.tablenhaphang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablenhaphang_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(19, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập hàng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tablesanpham
            // 
            this.tablesanpham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablesanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablesanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablesanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablesanpham.DefaultCellStyle = dataGridViewCellStyle4;
            this.tablesanpham.EnableHeadersVisualStyles = false;
            this.tablesanpham.Location = new System.Drawing.Point(13, 51);
            this.tablesanpham.Name = "tablesanpham";
            this.tablesanpham.RowHeadersWidth = 51;
            this.tablesanpham.RowTemplate.Height = 24;
            this.tablesanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablesanpham.Size = new System.Drawing.Size(618, 635);
            this.tablesanpham.TabIndex = 5;
            this.tablesanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablesanpham_CellContentClick);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Green;
            this.btnthem.FlatAppearance.BorderSize = 0;
            this.btnthem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnthem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(374, 700);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(109, 38);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(95, 709);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(204, 706);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(125, 22);
            this.txtsoluong.TabIndex = 2;
            this.txtsoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tablesanpham);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtsoluong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 751);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Enabled = false;
            this.txtmaphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmaphieu.Location = new System.Drawing.Point(192, 52);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.Size = new System.Drawing.Size(300, 27);
            this.txtmaphieu.TabIndex = 2;
            this.txtmaphieu.TextChanged += new System.EventHandler(this.txtmaphieu_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(14, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã phiếu nhập";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtnguoitao);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbxnhacungcap);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btncapnhat);
            this.panel2.Controls.Add(this.txttongtien);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.tablenhaphang);
            this.panel2.Controls.Add(this.txtmaphieu);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(632, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 751);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Green;
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnxoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.ImageIndex = 1;
            this.btnxoa.ImageList = this.imageList1;
            this.btnxoa.Location = new System.Drawing.Point(426, 700);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(109, 39);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // formsuachitietphieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 765);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "formsuachitietphieunhap";
            this.Text = "formsuachitietphieunhap";
            this.Load += new System.EventHandler(this.formsuachitietphieunhap_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tablenhaphang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesanpham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn masanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.TextBox txtnguoitao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxnhacungcap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncapnhat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView tablenhaphang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tablesanpham;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtmaphieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
    }
}