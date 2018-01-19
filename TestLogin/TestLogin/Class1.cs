using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TestLogin
{
    class Class1
    {
        public void checkNumberdouble(TextBox txt)
        {
            double x;
            if (txt.Text.Trim() == "")
            {
                return;
            }
            if (!double.TryParse(txt.Text, out x))
            {
                MessageBox.Show("ERROR");
                txt.Clear();
            }
        }

        public void checkNumberInt(TextBox txt,string str)
        { //ตรวจ int
            int x;
            if (txt.Text.Trim() == "")
            {
                return;
            }
            if (!int.TryParse(txt.Text, out x))
            {
                MessageBox.Show(str,"เกิดข้อผิดพลาด");
                txt.Clear();
            }
        }
        public void checkEmail(TextBox txt)
        {
            Regex emailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?
                                ^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+
                                [a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            
            if (emailRegex.IsMatch(txt.Text))
            {
                MessageBox.Show(txt.Text + "matches the expected format.", "Attention");
            }
        }
    }
}
