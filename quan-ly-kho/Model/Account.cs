﻿using System;
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

        public Account() { }

        public Account(string hoten, string tendangnhap, string matkhau, int trangthai, string email)
        {
            this.hoten = hoten;
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.trangthai = trangthai;
            this.email = email;
        }
    }
}
