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
    public partial class otp : Form
    {
        private string userEmail;
        public otp(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string otpcode = otptbox1.Text + otptbox2.Text + otptbox3.Text + otptbox4.Text + otptbox5.Text;


            if (Verify.VerifyOtp(userEmail, otpcode))
            {
                MessageBox.Show("OTP verified successfully!");
                this.Close(); 
                Dashboard dashboard = new Dashboard();
                dashboard.Show(); // Show the dashboard after successful OTP verification
                 // Hide the OTP form
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
