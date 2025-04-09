namespace quan_ly_kho.View.thongke
{
    partial class ncc_tk_form
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
            this.ncctk = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ncctk)).BeginInit();
            this.SuspendLayout();
            // 
            // ncctk
            // 
            this.ncctk.AllowUserToAddRows = false;
            this.ncctk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ncctk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ncctk.Location = new System.Drawing.Point(12, 12);
            this.ncctk.Name = "ncctk";
            this.ncctk.RowHeadersWidth = 51;
            this.ncctk.RowTemplate.Height = 24;
            this.ncctk.Size = new System.Drawing.Size(437, 426);
            this.ncctk.TabIndex = 1;
            // 
            // ncc_tk_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.ncctk);
            this.Name = "ncc_tk_form";
            this.Text = "ncc_tk_form";
            ((System.ComponentModel.ISupportInitialize)(this.ncctk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ncctk;
    }
}