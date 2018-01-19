using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestLogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            c.checkNumberdouble(textBox1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            c.checkEmail(textBox4);
        }


    }
}
