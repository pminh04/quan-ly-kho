using System.Windows.Forms;

namespace quan_ly_kho
{
    partial class nhacungcapform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.themmoip = new System.Windows.Forms.Panel();
            this.themmoibtn = new System.Windows.Forms.Button();
            this.pdfp = new System.Windows.Forms.Panel();
            this.pdfbtn = new System.Windows.Forms.Button();
            this.exportexcelp = new System.Windows.Forms.Panel();
            this.exportexcelbtn = new System.Windows.Forms.Button();
            this.importexcelp = new System.Windows.Forms.Panel();
            this.importexcelbtn = new System.Windows.Forms.Button();
            this.suap = new System.Windows.Forms.Panel();
            this.suabtn = new System.Windows.Forms.Button();
            this.xoap = new System.Windows.Forms.Panel();
            this.xoabtn = new System.Windows.Forms.Button();
            this.ncctb = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolbox = new System.Windows.Forms.GroupBox();
            this.themmoip.SuspendLayout();
            this.pdfp.SuspendLayout();
            this.exportexcelp.SuspendLayout();
            this.importexcelp.SuspendLayout();
            this.suap.SuspendLayout();
            this.xoap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncctb)).BeginInit();
            this.toolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // themmoip
            // 
            this.themmoip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.themmoip.Controls.Add(this.themmoibtn);
            this.themmoip.Location = new System.Drawing.Point(12, 25);
            this.themmoip.Name = "themmoip";
            this.themmoip.Size = new System.Drawing.Size(90, 93);
            this.themmoip.TabIndex = 2;
            // 
            // themmoibtn
            // 
            this.themmoibtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themmoibtn.Image = global::quan_ly_kho.Properties.Resources.icons8_add_male_user_group_50;
            this.themmoibtn.Location = new System.Drawing.Point(-12, -10);
            this.themmoibtn.Margin = new System.Windows.Forms.Padding(2);
            this.themmoibtn.Name = "themmoibtn";
            this.themmoibtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.themmoibtn.Size = new System.Drawing.Size(114, 110);
            this.themmoibtn.TabIndex = 1;
            this.themmoibtn.Text = "Thêm mới";
            this.themmoibtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.themmoibtn.UseVisualStyleBackColor = true;
            this.themmoibtn.Click += new System.EventHandler(this.themmoibtn_Click);
            // 
            // pdfp
            // 
            this.pdfp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pdfp.Controls.Add(this.pdfbtn);
            this.pdfp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pdfp.Location = new System.Drawing.Point(613, 25);
            this.pdfp.Name = "pdfp";
            this.pdfp.Size = new System.Drawing.Size(90, 93);
            this.pdfp.TabIndex = 7;
            // 
            // pdfbtn
            // 
            this.pdfbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfbtn.Image = global::quan_ly_kho.Properties.Resources.icons8_pdf_50;
            this.pdfbtn.Location = new System.Drawing.Point(-28, -17);
            this.pdfbtn.Margin = new System.Windows.Forms.Padding(2);
            this.pdfbtn.Name = "pdfbtn";
            this.pdfbtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pdfbtn.Size = new System.Drawing.Size(148, 118);
            this.pdfbtn.TabIndex = 1;
            this.pdfbtn.Text = "Xuất pdf";
            this.pdfbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pdfbtn.UseVisualStyleBackColor = true;
            // 
            // exportexcelp
            // 
            this.exportexcelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportexcelp.Controls.Add(this.exportexcelbtn);
            this.exportexcelp.Location = new System.Drawing.Point(475, 25);
            this.exportexcelp.Name = "exportexcelp";
            this.exportexcelp.Size = new System.Drawing.Size(90, 93);
            this.exportexcelp.TabIndex = 6;
            // 
            // exportexcelbtn
            // 
            this.exportexcelbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportexcelbtn.Image = global::quan_ly_kho.Properties.Resources.icons8_export_excel_50;
            this.exportexcelbtn.Location = new System.Drawing.Point(-28, -26);
            this.exportexcelbtn.Margin = new System.Windows.Forms.Padding(2);
            this.exportexcelbtn.Name = "exportexcelbtn";
            this.exportexcelbtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.exportexcelbtn.Size = new System.Drawing.Size(148, 127);
            this.exportexcelbtn.TabIndex = 1;
            this.exportexcelbtn.Text = "Xuất excel";
            this.exportexcelbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exportexcelbtn.UseVisualStyleBackColor = true;
            // 
            // importexcelp
            // 
            this.importexcelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.importexcelp.Controls.Add(this.importexcelbtn);
            this.importexcelp.Location = new System.Drawing.Point(340, 25);
            this.importexcelp.Name = "importexcelp";
            this.importexcelp.Size = new System.Drawing.Size(90, 93);
            this.importexcelp.TabIndex = 5;
            // 
            // importexcelbtn
            // 
            this.importexcelbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importexcelbtn.Image = global::quan_ly_kho.Properties.Resources.icons8_excel_50;
            this.importexcelbtn.Location = new System.Drawing.Point(-28, -26);
            this.importexcelbtn.Margin = new System.Windows.Forms.Padding(2);
            this.importexcelbtn.Name = "importexcelbtn";
            this.importexcelbtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.importexcelbtn.Size = new System.Drawing.Size(148, 127);
            this.importexcelbtn.TabIndex = 1;
            this.importexcelbtn.Text = "Nhập excel";
            this.importexcelbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.importexcelbtn.UseVisualStyleBackColor = true;
            // 
            // suap
            // 
            this.suap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.suap.Controls.Add(this.suabtn);
            this.suap.Location = new System.Drawing.Point(221, 25);
            this.suap.Name = "suap";
            this.suap.Size = new System.Drawing.Size(90, 93);
            this.suap.TabIndex = 4;
            // 
            // suabtn
            // 
            this.suabtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suabtn.Image = global::quan_ly_kho.Properties.Resources.icons8_edit_50;
            this.suabtn.Location = new System.Drawing.Point(-18, -26);
            this.suabtn.Margin = new System.Windows.Forms.Padding(2);
            this.suabtn.Name = "suabtn";
            this.suabtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.suabtn.Size = new System.Drawing.Size(121, 123);
            this.suabtn.TabIndex = 1;
            this.suabtn.Text = "Sửa";
            this.suabtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.suabtn.UseVisualStyleBackColor = true;
            this.suabtn.Click += new System.EventHandler(this.suabtn_Click);
            // 
            // xoap
            // 
            this.xoap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xoap.Controls.Add(this.xoabtn);
            this.xoap.Location = new System.Drawing.Point(124, 25);
            this.xoap.Name = "xoap";
            this.xoap.Size = new System.Drawing.Size(74, 93);
            this.xoap.TabIndex = 3;
            // 
            // xoabtn
            // 
            this.xoabtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoabtn.Image = global::quan_ly_kho.Properties.Resources.icons8_trash_can_50;
            this.xoabtn.Location = new System.Drawing.Point(-17, -25);
            this.xoabtn.Margin = new System.Windows.Forms.Padding(2);
            this.xoabtn.Name = "xoabtn";
            this.xoabtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.xoabtn.Size = new System.Drawing.Size(120, 123);
            this.xoabtn.TabIndex = 1;
            this.xoabtn.Text = "Xóa";
            this.xoabtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.xoabtn.UseVisualStyleBackColor = true;
            this.xoabtn.Click += new System.EventHandler(this.xoabtn_Click);
            // 
            // ncctb
            // 
            this.ncctb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ncctb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ncctb.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ncctb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ncctb.ColumnHeadersHeight = 29;
            this.ncctb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.sdt,
            this.diachi});
            this.ncctb.EnableHeadersVisualStyles = false;
            this.ncctb.Location = new System.Drawing.Point(-2, 123);
            this.ncctb.Name = "ncctb";
            this.ncctb.RowHeadersWidth = 51;
            this.ncctb.RowTemplate.Height = 24;
            this.ncctb.Size = new System.Drawing.Size(962, 559);
            this.ncctb.TabIndex = 4;
            this.ncctb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ncctb_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "manhacungcap";
            this.id.HeaderText = "Mã nhà cung cấp";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 200;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "tennhacungcap";
            this.ten.HeaderText = "Tên nhà cung cấp";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 200;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 200;
            // 
            // diachi
            // 
            this.diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diachi.DataPropertyName = "diachi";
            this.diachi.FillWeight = 10000F;
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // toolbox
            // 
            this.toolbox.BackColor = System.Drawing.Color.White;
            this.toolbox.Controls.Add(this.pdfp);
            this.toolbox.Controls.Add(this.themmoip);
            this.toolbox.Controls.Add(this.exportexcelp);
            this.toolbox.Controls.Add(this.xoap);
            this.toolbox.Controls.Add(this.importexcelp);
            this.toolbox.Controls.Add(this.suap);
            this.toolbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbox.Location = new System.Drawing.Point(0, 0);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(960, 126);
            this.toolbox.TabIndex = 5;
            this.toolbox.TabStop = false;
            this.toolbox.Text = "Chức năng";
            // 
            // nhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.ncctb);
            this.Name = "nhacungcap";
            this.Text = "nhacungcap";
            this.Load += new System.EventHandler(this.nhacungcap_Load);
            this.themmoip.ResumeLayout(false);
            this.pdfp.ResumeLayout(false);
            this.exportexcelp.ResumeLayout(false);
            this.importexcelp.ResumeLayout(false);
            this.suap.ResumeLayout(false);
            this.xoap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ncctb)).EndInit();
            this.toolbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button themmoibtn;
        private System.Windows.Forms.Panel themmoip;
        private Panel exportexcelp;
        private Button exportexcelbtn;
        private Panel importexcelp;
        private Button importexcelbtn;
        private Panel suap;
        private Button suabtn;
        private Panel xoap;
        private Button xoabtn;
        private Panel pdfp;
        private Button pdfbtn;
        private DataGridView ncctb;
        private GroupBox toolbox;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn ten;
        private DataGridViewTextBoxColumn sdt;
        private DataGridViewTextBoxColumn diachi;
    }
}