namespace quan_ly_kho.View.phieunhap
{
    partial class chitietphieunhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chitietphieunhap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tablechitietphieunhap = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnnhapexcel = new System.Windows.Forms.Button();
            this.btnxuatexcel = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablechitietphieunhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnnhapexcel);
            this.groupBox1.Controls.Add(this.btnxuatexcel);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(8, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmax);
            this.groupBox2.Controls.Add(this.txtmin);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(633, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 127);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc theo giá";
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(336, 53);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(176, 27);
            this.txtmax.TabIndex = 3;
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(67, 53);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(175, 27);
            this.txtmin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tablechitietphieunhap);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-6, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 549);
            this.panel2.TabIndex = 6;
            // 
            // tablechitietphieunhap
            // 
            this.tablechitietphieunhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablechitietphieunhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablechitietphieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablechitietphieunhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablechitietphieunhap.EnableHeadersVisualStyles = false;
            this.tablechitietphieunhap.Location = new System.Drawing.Point(8, 49);
            this.tablechitietphieunhap.Name = "tablechitietphieunhap";
            this.tablechitietphieunhap.RowHeadersWidth = 51;
            this.tablechitietphieunhap.RowTemplate.Height = 24;
            this.tablechitietphieunhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablechitietphieunhap.Size = new System.Drawing.Size(1164, 497);
            this.tablechitietphieunhap.TabIndex = 1;
            this.tablechitietphieunhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablechitietphieunhap_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(474, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "CHI TIẾT PHIẾU NHẬP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(-6, -14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 157);
            this.panel1.TabIndex = 5;
            // 
            // btnnhapexcel
            // 
            this.btnnhapexcel.FlatAppearance.BorderSize = 0;
            this.btnnhapexcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnnhapexcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnnhapexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnhapexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnnhapexcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnnhapexcel.ImageIndex = 5;
            this.btnnhapexcel.ImageList = this.imageList2;
            this.btnnhapexcel.Location = new System.Drawing.Point(441, 26);
            this.btnnhapexcel.Name = "btnnhapexcel";
            this.btnnhapexcel.Size = new System.Drawing.Size(138, 95);
            this.btnnhapexcel.TabIndex = 4;
            this.btnnhapexcel.Text = "Nhập excel";
            this.btnnhapexcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnhapexcel.UseVisualStyleBackColor = true;
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
            // chitietphieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 684);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "chitietphieunhap";
            this.Text = "chitietphieunhap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablechitietphieunhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnnhapexcel;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnxuatexcel;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tablechitietphieunhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}