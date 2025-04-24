using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_kho.Model
{
    public class SanPhamModel
    {
        public string masanpham { get; set; }
        public string tensanpham { get; set; }
        public string xuatxu { get; set; }
        public string maloaihang { get; set; }
        public int soluong { get; set; }

        public string loaitk { get; set; }
        public string tukhoa { get; set; }

        public DataGridView sptab { get; set; }
        public SanPhamModel() { }

        public SanPhamModel(string masanpham, string tensanpham, string xuatxu, string maloaihang, int soluong)

        {
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.xuatxu = xuatxu;
            this.maloaihang = maloaihang;
            this.soluong = soluong;

        }

        public SanPhamModel(string loaitk, string tukhoa)
        {
            this.loaitk = loaitk;
            this.tukhoa = tukhoa;
        }

        public SanPhamModel(DataGridView sptab)
        {
            this.sptab = sptab;
        }

    }
}




