using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace quan_ly_kho.Controller
{
    internal class checkrule
    {
        public bool checkmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        public bool checkSdt(string dt)
        {
            string pattern = @"^(?:\+84|84|0)(?:\d{9})$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(dt);
        }
    }
}
