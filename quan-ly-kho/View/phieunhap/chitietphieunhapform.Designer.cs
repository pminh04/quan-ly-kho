﻿namespace quan_ly_kho.View.phieunhap
{
    partial class chitietphieunhapform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chitietphieunhapform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxemchitiet = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnxuatexcel = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnloc = new System.Windows.Forms.Button();
            this.txtGiaDen = new System.Windows.Forms.TextBox();
            this.txtGiaTu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tablechitietphieunhap = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigiantao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoitao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablechitietphieunhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnxemchitiet);
            this.groupBox1.Controls.Add(this.btnxuatexcel);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(8, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnxemchitiet
            // 
            this.btnxemchitiet.FlatAppearance.BorderSize = 0;
            this.btnxemchitiet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnxemchitiet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnxemchitiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxemchitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxemchitiet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnxemchitiet.ImageIndex = 7;
            this.btnxemchitiet.ImageList = this.imageList2;
            this.btnxemchitiet.Location = new System.Drawing.Point(441, 26);
            this.btnxemchitiet.Name = "btnxemchitiet";
            this.btnxemchitiet.Size = new System.Drawing.Size(138, 95);
            this.btnxemchitiet.TabIndex = 4;
            this.btnxemchitiet.Text = "Xem chi tiết";
            this.btnxemchitiet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnxemchitiet.UseVisualStyleBackColor = true;
            this.btnxemchitiet.Click += new System.EventHandler(this.btnxemchitiet_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "them.png");
            this.imageList2.Images.SetKeyName(1, "sửa.png");
            this.imageList2.Images.SetKeyName(2, "excel.png");
            this.imageList2.Images.SetKeyName(3, "rác.png");
            this.imageList2.Images.SetKeyName(4, "icons8-edit-50.png");
            this.imageList2.Images.SetKeyName(5, "icons8-excel-50.png");
            this.imageList2.Images.SetKeyName(6, "icons8-trash-can-50.png");
            this.imageList2.Images.SetKeyName(7, "chitiet.png");
            this.imageList2.Images.SetKeyName(8, "loc.png");
            // 
            // btnxuatexcel
            // 
            this.btnxuatexcel.FlatAppearance.BorderSize = 0;
            this.btnxuatexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxuatexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxuatexcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnxuatexcel.ImageIndex = 5;
            this.btnxuatexcel.ImageList = this.imageList2;
            this.btnxuatexcel.Location = new System.Drawing.Point(295, 26);
            this.btnxuatexcel.Name = "btnxuatexcel";
            this.btnxuatexcel.Size = new System.Drawing.Size(128, 95);
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
            this.btnxoa.ImageIndex = 6;
            this.btnxoa.ImageList = this.imageList2;
            this.btnxoa.Location = new System.Drawing.Point(160, 26);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(91, 95);
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
            this.btnsua.ImageIndex = 4;
            this.btnsua.ImageList = this.imageList2;
            this.btnsua.Location = new System.Drawing.Point(15, 26);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(91, 95);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnloc);
            this.groupBox2.Controls.Add(this.txtGiaDen);
            this.groupBox2.Controls.Add(this.txtGiaTu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(633, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 127);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc theo giá";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnloc
            // 
            this.btnloc.FlatAppearance.BorderSize = 0;
            this.btnloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnloc.ImageIndex = 8;
            this.btnloc.ImageList = this.imageList2;
            this.btnloc.Location = new System.Drawing.Point(437, 17);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(84, 95);
            this.btnloc.TabIndex = 4;
            this.btnloc.Text = "Lọc";
            this.btnloc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // txtGiaDen
            // 
            this.txtGiaDen.Location = new System.Drawing.Point(289, 53);
            this.txtGiaDen.Name = "txtGiaDen";
            this.txtGiaDen.Size = new System.Drawing.Size(132, 27);
            this.txtGiaDen.TabIndex = 3;
            // 
            // txtGiaTu
            // 
            this.txtGiaTu.Location = new System.Drawing.Point(67, 53);
            this.txtGiaTu.Name = "txtGiaTu";
            this.txtGiaTu.Size = new System.Drawing.Size(133, 27);
            this.txtGiaTu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(4, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 157);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tablechitietphieunhap);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(4, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 549);
            this.panel2.TabIndex = 4;
            // 
            // tablechitietphieunhap
            // 
            this.tablechitietphieunhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablechitietphieunhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablechitietphieunhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablechitietphieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablechitietphieunhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieu,
            this.thoigiantao,
            this.nguoitao,
            this.manhacungcap,
            this.tennhacungcap,
            this.tongtien});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablechitietphieunhap.DefaultCellStyle = dataGridViewCellStyle6;
            this.tablechitietphieunhap.EnableHeadersVisualStyles = false;
            this.tablechitietphieunhap.Location = new System.Drawing.Point(8, 49);
            this.tablechitietphieunhap.Name = "tablechitietphieunhap";
            this.tablechitietphieunhap.RowHeadersWidth = 51;
            this.tablechitietphieunhap.RowTemplate.Height = 24;
            this.tablechitietphieunhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablechitietphieunhap.Size = new System.Drawing.Size(1164, 497);
            this.tablechitietphieunhap.TabIndex = 1;
            this.tablechitietphieunhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablechitietphieunhap_CellClick);
            this.tablechitietphieunhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablechitietphieunhap_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(474, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "CHI TIẾT PHIẾU NHẬP";
            // 
            // maphieu
            // 
            this.maphieu.DataPropertyName = "maphieu";
            this.maphieu.HeaderText = "Mã phiếu";
            this.maphieu.MinimumWidth = 6;
            this.maphieu.Name = "maphieu";
            // 
            // thoigiantao
            // 
            this.thoigiantao.DataPropertyName = "thoigiantao";
            this.thoigiantao.HeaderText = "Thời gian tạo";
            this.thoigiantao.MinimumWidth = 6;
            this.thoigiantao.Name = "thoigiantao";
            // 
            // nguoitao
            // 
            this.nguoitao.DataPropertyName = "nguoitao";
            this.nguoitao.HeaderText = "Người tạo";
            this.nguoitao.MinimumWidth = 6;
            this.nguoitao.Name = "nguoitao";
            // 
            // manhacungcap
            // 
            this.manhacungcap.DataPropertyName = "manhacungcap";
            this.manhacungcap.HeaderText = "Mã nhà cung cấp";
            this.manhacungcap.MinimumWidth = 6;
            this.manhacungcap.Name = "manhacungcap";
            this.manhacungcap.Visible = false;
            // 
            // tennhacungcap
            // 
            this.tennhacungcap.DataPropertyName = "tennhacungcap";
            this.tennhacungcap.HeaderText = "Tên nhà cung cấp";
            this.tennhacungcap.MinimumWidth = 6;
            this.tennhacungcap.Name = "tennhacungcap";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            // 
            // chitietphieunhapform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 731);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chitietphieunhapform";
            this.Text = "chitietphieunhapform";
            this.Load += new System.EventHandler(this.chitietphieunhapform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablechitietphieunhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxemchitiet;
        private System.Windows.Forms.Button btnxuatexcel;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGiaTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaDen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tablechitietphieunhap;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigiantao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoitao;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
    }
}