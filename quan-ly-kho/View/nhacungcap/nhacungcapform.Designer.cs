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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.themmoip = new System.Windows.Forms.Panel();
            this.themmoibtn = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.themmoip.SuspendLayout();
            this.exportexcelp.SuspendLayout();
            this.importexcelp.SuspendLayout();
            this.suap.SuspendLayout();
            this.xoap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncctb)).BeginInit();
            this.toolbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // themmoip
            // 
            this.themmoip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.themmoip.Controls.Add(this.themmoibtn);
            this.themmoip.Location = new System.Drawing.Point(12, 22);
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
            // exportexcelp
            // 
            this.exportexcelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportexcelp.Controls.Add(this.exportexcelbtn);
            this.exportexcelp.Location = new System.Drawing.Point(475, 22);
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
            this.exportexcelbtn.Click += new System.EventHandler(this.exportexcelbtn_Click);
            // 
            // importexcelp
            // 
            this.importexcelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.importexcelp.Controls.Add(this.importexcelbtn);
            this.importexcelp.Location = new System.Drawing.Point(340, 22);
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
            this.importexcelbtn.Click += new System.EventHandler(this.importexcelbtn_Click);
            // 
            // suap
            // 
            this.suap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.suap.Controls.Add(this.suabtn);
            this.suap.Location = new System.Drawing.Point(221, 22);
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
            this.xoap.Location = new System.Drawing.Point(124, 22);
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
            this.ncctb.AllowUserToAddRows = false;
            this.ncctb.AllowUserToDeleteRows = false;
            this.ncctb.AllowUserToResizeRows = false;
            this.ncctb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ncctb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ncctb.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(1)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ncctb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ncctb.ColumnHeadersHeight = 29;
            this.ncctb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.sdt,
            this.diachi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ncctb.DefaultCellStyle = dataGridViewCellStyle2;
            this.ncctb.EnableHeadersVisualStyles = false;
            this.ncctb.Location = new System.Drawing.Point(12, 47);
            this.ncctb.Name = "ncctb";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ncctb.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ncctb.RowHeadersWidth = 51;
            this.ncctb.RowTemplate.Height = 24;
            this.ncctb.Size = new System.Drawing.Size(1186, 565);
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
            this.toolbox.Controls.Add(this.themmoip);
            this.toolbox.Controls.Add(this.exportexcelp);
            this.toolbox.Controls.Add(this.xoap);
            this.toolbox.Controls.Add(this.importexcelp);
            this.toolbox.Controls.Add(this.suap);
            this.toolbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbox.Location = new System.Drawing.Point(3, 3);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(777, 119);
            this.toolbox.TabIndex = 5;
            this.toolbox.TabStop = false;
            this.toolbox.Text = "Chức năng";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ncctb);
            this.panel1.Location = new System.Drawing.Point(0, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 627);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(474, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH SÁCH NHÀ CUNG CẤP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.toolbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1210, 125);
            this.panel2.TabIndex = 7;
            // 
            // nhacungcapform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 758);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "nhacungcapform";
            this.Text = "nhacungcap";
            this.Load += new System.EventHandler(this.nhacungcap_Load);
            this.themmoip.ResumeLayout(false);
            this.exportexcelp.ResumeLayout(false);
            this.importexcelp.ResumeLayout(false);
            this.suap.ResumeLayout(false);
            this.xoap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ncctb)).EndInit();
            this.toolbox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private DataGridView ncctb;
        private GroupBox toolbox;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn ten;
        private DataGridViewTextBoxColumn sdt;
        private DataGridViewTextBoxColumn diachi;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}