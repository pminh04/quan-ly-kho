namespace quan_ly_kho.View.phieuxuat
{
    partial class phieuxuatform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabctpx = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnloc = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.txtGiaDen = new System.Windows.Forms.TextBox();
            this.txtGiaTu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxemchitiet = new System.Windows.Forms.Button();
            this.btnxuatexcel = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabctpx)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctpx
            // 
            this.tabctpx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabctpx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabctpx.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabctpx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabctpx.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabctpx.EnableHeadersVisualStyles = false;
            this.tabctpx.Location = new System.Drawing.Point(7, 45);
            this.tabctpx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabctpx.Name = "tabctpx";
            this.tabctpx.RowHeadersWidth = 51;
            this.tabctpx.RowTemplate.Height = 24;
            this.tabctpx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabctpx.Size = new System.Drawing.Size(1051, 419);
            this.tabctpx.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tabctpx);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(10, 131);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 502);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(429, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "CHI TIẾT PHIẾU NHẬP";
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
            this.groupBox2.Location = new System.Drawing.Point(571, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(479, 114);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc theo giá";
            // 
            // btnloc
            // 
            this.btnloc.FlatAppearance.BorderSize = 0;
            this.btnloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnloc.ImageList = this.imageList2;
            this.btnloc.Location = new System.Drawing.Point(388, 14);
            this.btnloc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(75, 86);
            this.btnloc.TabIndex = 4;
            this.btnloc.Text = "Lọc";
            this.btnloc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnloc.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtGiaDen
            // 
            this.txtGiaDen.Location = new System.Drawing.Point(257, 42);
            this.txtGiaDen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaDen.Name = "txtGiaDen";
            this.txtGiaDen.Size = new System.Drawing.Size(118, 27);
            this.txtGiaDen.TabIndex = 3;
            // 
            // txtGiaTu
            // 
            this.txtGiaTu.Location = new System.Drawing.Point(60, 42);
            this.txtGiaTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaTu.Name = "txtGiaTu";
            this.txtGiaTu.Size = new System.Drawing.Size(119, 27);
            this.txtGiaTu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
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
            this.panel1.Location = new System.Drawing.Point(10, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 140);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnxemchitiet);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnxuatexcel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(15, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(550, 114);
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
            this.btnxemchitiet.ImageList = this.imageList2;
            this.btnxemchitiet.Location = new System.Drawing.Point(404, 19);
            this.btnxemchitiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxemchitiet.Name = "btnxemchitiet";
            this.btnxemchitiet.Size = new System.Drawing.Size(123, 91);
            this.btnxemchitiet.TabIndex = 4;
            this.btnxemchitiet.Text = "Xem chi tiết";
            this.btnxemchitiet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnxemchitiet.UseVisualStyleBackColor = true;
            // 
            // btnxuatexcel
            // 
            this.btnxuatexcel.FlatAppearance.BorderSize = 0;
            this.btnxuatexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxuatexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxuatexcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnxuatexcel.ImageList = this.imageList2;
            this.btnxuatexcel.Location = new System.Drawing.Point(258, 19);
            this.btnxuatexcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxuatexcel.Name = "btnxuatexcel";
            this.btnxuatexcel.Size = new System.Drawing.Size(117, 91);
            this.btnxuatexcel.TabIndex = 3;
            this.btnxuatexcel.Text = "Xuất excel";
            this.btnxuatexcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnxuatexcel.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnxoa.ImageList = this.imageList2;
            this.btnxoa.Location = new System.Drawing.Point(143, 19);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(76, 91);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.FlatAppearance.BorderSize = 0;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsua.ImageList = this.imageList2;
            this.btnsua.Location = new System.Drawing.Point(17, 19);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(81, 91);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // phieuxuatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "phieuxuatform";
            this.Text = "phieuxuat";
            ((System.ComponentModel.ISupportInitialize)(this.tabctpx)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView tabctpx;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox txtGiaDen;
        private System.Windows.Forms.TextBox txtGiaTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxemchitiet;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxuatexcel;
    }
}