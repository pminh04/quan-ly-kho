using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quan_ly_kho.Controller;
using quan_ly_kho.View.nhacungcap;

namespace quan_ly_kho
{
    public partial class nhacungcapform : Form
    {
        string table_name = "nhacungcap";
        public nhacungcapform()
        {
            InitializeComponent();
        }


        private void themmoibtn_Click(object sender, EventArgs e)
        {
            ncc_them f1 = new ncc_them();
            f1.BringToFront();
            f1.Show();
            f1.FormClosed += (obj, args) =>
            {
                loaddata.show_ncc(ncctb, table_name);
            };

        }

        private void nhacungcap_Load(object sender, EventArgs e)
        {
            loaddata.show_ncc(ncctb, table_name);
        }

        private void xoabtn_Click(object sender, EventArgs e)
        {
            Model.nhacungcap ncc = new Model.nhacungcap(selectedId);
            DialogResult result = MessageBox.Show("Có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Controller.Xoa.xoa_ncc(ncc);
                MessageBox.Show("Xóa thành công!");

                loaddata.show_ncc(ncctb, table_name);
            }
        }

        private string selectedId;
        private string selectedTen;
        private string selectedSdt;
        private string selectedDiachi;
        private void ncctb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i >= 0 && !ncctb.Rows[i].IsNewRow)
            {
                selectedId = ncctb.Rows[e.RowIndex].Cells["id"].Value.ToString();
                selectedTen = ncctb.Rows[e.RowIndex].Cells["ten"].Value.ToString();
                selectedSdt = ncctb.Rows[e.RowIndex].Cells["sdt"].Value.ToString();
                selectedDiachi = ncctb.Rows[e.RowIndex].Cells["diachi"].Value.ToString();
            }
        }

        private void suabtn_Click(object sender, EventArgs e)
        {
            
            Model.nhacungcap ncc = new Model.nhacungcap(selectedId,selectedTen,selectedSdt,selectedDiachi);
            if(selectedId == null) 
            { 
                MessageBox.Show("Vui long chọn dữ liệu cần sửa.");
                return;
            }
            ncc_sua f1 = new ncc_sua(ncc);
            f1.BringToFront();
            f1.Show();
            f1.FormClosed += (obj, args) =>
            {
                loaddata.show_ncc(ncctb, table_name);
            };
        }
    }
}
