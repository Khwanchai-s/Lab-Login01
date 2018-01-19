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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        testDataContext db = new testDataContext();
        private string _userid;
        private string _userName;
        private string _firstName;
        private string _position;
        public string UserID { get { return _userid; } }
        public string UserName { get { return _userName; } }
        public string FirstName { get { return _firstName; } }
        public string Position { get { return _position; } }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ทดสอบ Admin
            txtUserName.Text = "u01";
            txtPassword.Text = "u01";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ทดสอบ User
            txtUserName.Text = "u02";
            txtPassword.Text = "u02";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var q = (from t in db.users
                     where t.username == txtUserName.Text && t.passwords == txtPassword.Text
                     select new { t.userID,t.firstname, t.username, t.position }).First();
            if (q != null)
            {
                _userid = q.userID.ToString();
                _userName = q.username;
                _firstName = q.firstname;
                _position = q.position;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Fail");
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtUserName.Focus();
            }
        }
    }
}
