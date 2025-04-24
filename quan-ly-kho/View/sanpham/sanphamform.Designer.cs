namespace quan_ly_kho.View.sanpham
{
    partial class sanphamform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sanphamform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnnhapexcel = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnxuatexcel = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tablesanpham = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.masanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuatxu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaihang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloaihang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablesanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Location = new System.Drawing.Point(-1, -7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1191, 157);
            this.panel5.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnnhapexcel);
            this.groupBox1.Controls.Add(this.btnxuatexcel);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnnhapexcel
            // 
            this.btnnhapexcel.FlatAppearance.BorderSize = 0;
            this.btnnhapexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnhapexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnnhapexcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnnhapexcel.ImageIndex = 4;
            this.btnnhapexcel.ImageList = this.imageList2;
            this.btnnhapexcel.Location = new System.Drawing.Point(485, 26);
            this.btnnhapexcel.Name = "btnnhapexcel";
            this.btnnhapexcel.Size = new System.Drawing.Size(116, 111);
            this.btnnhapexcel.TabIndex = 4;
            this.btnnhapexcel.Text = "Nhập excel";
            this.btnnhapexcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnhapexcel.UseVisualStyleBackColor = true;
            this.btnnhapexcel.Click += new System.EventHandler(this.btnnhapexcel_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "them.png");
            this.imageList2.Images.SetKeyName(1, "icons8-trash-can-50.png");
            this.imageList2.Images.SetKeyName(2, "excel.png");
            this.imageList2.Images.SetKeyName(3, "icons8-edit-50.png");
            this.imageList2.Images.SetKeyName(4, "icons8-excel-50.png");
            this.imageList2.Images.SetKeyName(5, "rác.png");
            // 
            // btnxuatexcel
            // 
            this.btnxuatexcel.FlatAppearance.BorderSize = 0;
            this.btnxuatexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxuatexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxuatexcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnxuatexcel.ImageIndex = 4;
            this.btnxuatexcel.ImageList = this.imageList2;
            this.btnxuatexcel.Location = new System.Drawing.Point(349, 26);
            this.btnxuatexcel.Name = "btnxuatexcel";
            this.btnxuatexcel.Size = new System.Drawing.Size(119, 111);
            this.btnxuatexcel.TabIndex = 3;
            this.btnxuatexcel.Text = "Xuất excel";
            this.btnxuatexcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnxuatexcel.UseVisualStyleBackColor = true;
            this.btnxuatexcel.Click += new System.EventHandler(this.btnxuatexcel_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnxoa.ImageIndex = 5;
            this.btnxoa.ImageList = this.imageList2;
            this.btnxoa.Location = new System.Drawing.Point(227, 32);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(102, 105);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.FlatAppearance.BorderSize = 0;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsua.ImageIndex = 3;
            this.btnsua.ImageList = this.imageList2;
            this.btnsua.Location = new System.Drawing.Point(120, 35);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(91, 102);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "them.png";
            this.button1.ImageList = this.imageList2;
            this.button1.Location = new System.Drawing.Point(6, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 105);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tablesanpham);
            this.panel1.Location = new System.Drawing.Point(-1, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 584);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(502, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // tablesanpham
            // 
            this.tablesanpham.AllowUserToAddRows = false;
            this.tablesanpham.AllowUserToDeleteRows = false;
            this.tablesanpham.AllowUserToResizeRows = false;
            this.tablesanpham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablesanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablesanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablesanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablesanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masanpham,
            this.tensanpham,
            this.xuatxu,
            this.tenloaihang,
            this.maloaihang,
            this.soluong});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablesanpham.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablesanpham.EnableHeadersVisualStyles = false;
            this.tablesanpham.Location = new System.Drawing.Point(9, 53);
            this.tablesanpham.Name = "tablesanpham";
            this.tablesanpham.RowHeadersWidth = 51;
            this.tablesanpham.RowTemplate.Height = 24;
            this.tablesanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablesanpham.Size = new System.Drawing.Size(1164, 557);
            this.tablesanpham.TabIndex = 1;
            this.tablesanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablesanpham_CellClick);
            this.tablesanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablesanpham_CellContentClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // masanpham
            // 
            this.masanpham.DataPropertyName = "masanpham";
            this.masanpham.HeaderText = "Mã sản phẩm";
            this.masanpham.MinimumWidth = 6;
            this.masanpham.Name = "masanpham";
            // 
            // tensanpham
            // 
            this.tensanpham.DataPropertyName = "tensanpham";
            this.tensanpham.HeaderText = "Tên sản phẩm";
            this.tensanpham.MinimumWidth = 6;
            this.tensanpham.Name = "tensanpham";
            // 
            // xuatxu
            // 
            this.xuatxu.DataPropertyName = "xuatxu";
            this.xuatxu.HeaderText = "Xuất xứ";
            this.xuatxu.MinimumWidth = 6;
            this.xuatxu.Name = "xuatxu";
            // 
            // tenloaihang
            // 
            this.tenloaihang.DataPropertyName = "tenloaihang";
            this.tenloaihang.HeaderText = "Loại hàng";
            this.tenloaihang.MinimumWidth = 6;
            this.tenloaihang.Name = "tenloaihang";
            // 
            // maloaihang
            // 
            this.maloaihang.DataPropertyName = "maloaihang";
            this.maloaihang.HeaderText = "Mã loại hàng";
            this.maloaihang.MinimumWidth = 6;
            this.maloaihang.Name = "maloaihang";
            this.maloaihang.Visible = false;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            // 
            // sanphamform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 732);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "sanphamform";
            this.Text = "sanpham";
            this.Load += new System.EventHandler(this.sanphamform_Load);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablesanpham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablesanpham;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnnhapexcel;
        private System.Windows.Forms.Button btnxuatexcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn masanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuatxu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaihang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaihang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
    }
}