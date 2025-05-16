using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto
{

    public partial class Registerpage : UserControl
    {
        private homepage _home;
        public Registerpage(homepage home)
        {
            InitializeComponent();
            _home = home;
        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _home.Showthisform(new LoginPage(_home));

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string fname = fntbox.Text;
            string lname = lntbox.Text;
            string email = emailtbox.Text;
            string pass = passtbox.Text;
            string cpass = cpasstbox.Text;
            Connection con = new Connection();

            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(cpass))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else if (pass.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }
            else if (pass != cpass)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            else
            {
                con.InsertData(fname, lname, email, pass);
                MessageBox.Show("Registration Successful");
                _home.Showthisform(new LoginPage(_home));
                
            }
        }
    }
}
