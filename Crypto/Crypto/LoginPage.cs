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
    public partial class LoginPage : UserControl
    {
        private homepage _home;
        public LoginPage(homepage home)
        {
            InitializeComponent();
            _home = home;
        }

       

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _home.Showthisform(new Registerpage(_home));
        }

        

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            string email = emailtbox.Text;
            string pass = passtbox.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
           
            
            else if (pass.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }
            else
            {
                Connection conn = new Connection();
                if (conn.ValidateLogin(email, pass))
                {
                    MessageBox.Show("Login Succesfull");
                    Dashboard dash = new Dashboard();
                    dash.Show();
                    _home.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid email or password.");
                }
                

            }
        }
    }
}
