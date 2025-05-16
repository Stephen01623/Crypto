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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public void Showform(object form)
        {
            string panel1 = Mainpanel.Name;
            Mainpanel.Controls.Clear();
            Form frm = form as Form;
            frm.TopLevel = false;
            Mainpanel.Controls.Add(frm);
            frm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Showform(new dash());
        }

        private void dashbtn_Click(object sender, EventArgs e)
        {
            Showform(new dash());
        }

        private void Exchbtn_Click(object sender, EventArgs e)
        {
            Showform(new Exchange());
        }

        private void wallbtn_Click(object sender, EventArgs e)
        {
            Showform(new wallet());
        }

        private void hisbtn_Click(object sender, EventArgs e)
        {
            Showform(new history());
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
