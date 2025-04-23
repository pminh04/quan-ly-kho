using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Model
{
    public class Customer
    {
        public string id { get; set; }             
        public string hoten{ get; set; }           
        public string email { get; set; }         
        public string sdt { get; set; }   
        public string diachi { get; set; }
        public string loaitk { get; set; }
        public string tukhoa { get; set; }

        public Customer() { }

        public Customer(string id, string ten, string email, string soDienThoai, string diaChi)
        {
            this.id = id;
            this.hoten = ten;
            this.email = email;
            this.sdt = soDienThoai;
            this.diachi = diaChi;
        }
        public Customer(string loaitk, string tukhoa)
        {
            this.loaitk = loaitk;
            this.tukhoa = tukhoa;
        }
    }
}
