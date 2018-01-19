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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Image img = Image.FromFile(@"D:\LabCSharpClass0\TestLogin\TestLogin\test.jpg");
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {   control.BackgroundImage = System.Drawing.Image.FromFile(@"D:\LabCSharpClass0\TestLogin\TestLogin\test.jpg");
                    control.BackgroundImageLayout = ImageLayout.Stretch;
                    // control.BackColor = Color.AliceBlue;
                    //Properties.Resources.duk;
                    //MessageBox.Show("MDI");
                    break;
                }
            }
        }
        //--------สำหรับเก็บค่าที่ผ่านการ Login มา--------
        private string _userID;
        private string _userName;
        private string _firstName;
        private string _position;
        private string status = "Logout";
        //----------------------------------------
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmLogin f = new frmLogin())
            {
                f.ShowDialog();
                _userID = f.UserID;
                _userName = f.UserName;
                _firstName = f.FirstName;
                _position = f.Position;
            }
            this.Text += _firstName + "  " + _position;
            if (_position == "ผู้ดูแลระบบ")
            {
                enableMenu( false, false,true);

            } else if(_position =="ธุรการ")
            {
                enableMenu(false, true, false);
            }
        }

      
        private void ผดแลToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_position == "ผู้ดูแลระบบ")
            {
                MessageBox.Show("ยินดีต้อนรับ ผู้ดูแล [Administrator]");
            }
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _userName = null;
            _firstName = null;
            _position = null;
            this.Text = "ระบบงาน ตัวอย่าง ";
            enableMenu(true, false, false);
        }

        private void logoutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _userName = null;
            _firstName = null;
            _position = null;
            this.Text = "ระบบงาน ตัวอย่าง ";
            enableMenu(true, false, false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "ระบบงาน ตัวอย่าง ";
            enableMenu(true, false,false);
            //loginToolStripMenuItem.PerformClick();
        }

        private void ธรการToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();
        }
        private void enableMenu(bool login, bool user, bool admin)
        {//
            menuStrip1.Visible = login;
            menuStrip2.Visible = user;
            menuStrip3.Visible = admin;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
