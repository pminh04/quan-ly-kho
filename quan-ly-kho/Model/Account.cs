using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Model
{
    public class Account
    {
        public string hoten { get; set; }
        public string tendangnhap { get; set; }
        public string matkhau { get; set; }
        public int trangthai { get; set; }
        public string email { get; set; }
        public string loaitk { get; set; }
        public string tukhoa { get; set; }
        public string vaitro { get; set; }


        public Account() { }
        public Account(string hoten, string tendangnhap, string matkhau, int trangthai, string email,string vaitro)
        {
            this.hoten = hoten;
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.trangthai = trangthai;
            this.email = email;
            this.vaitro = vaitro;
        }

        public Account(string loaitk, string tukhoa)
        {
            this.loaitk = loaitk;
            this.tukhoa = tukhoa;
        }

        public Account(string tendangnhap,string matkhau, int trangthai)
        {
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.trangthai = trangthai;
        }

    }
}
