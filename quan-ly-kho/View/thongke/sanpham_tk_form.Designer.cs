namespace quan_ly_kho.View.thongke
{
    partial class sanpham_tk_form
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
            this.sptk = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sptk)).BeginInit();
            this.SuspendLayout();
            // 
            // sptk
            // 
            this.sptk.AllowUserToAddRows = false;
            this.sptk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sptk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sptk.Location = new System.Drawing.Point(12, 12);
            this.sptk.Name = "sptk";
            this.sptk.RowHeadersWidth = 51;
            this.sptk.RowTemplate.Height = 24;
            this.sptk.Size = new System.Drawing.Size(330, 426);
            this.sptk.TabIndex = 0;
            // 
            // sanpham_tk_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.sptk);
            this.Name = "sanpham_tk_form";
            this.Text = "sanpham_tk_form";
            ((System.ComponentModel.ISupportInitialize)(this.sptk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sptk;
    }
}