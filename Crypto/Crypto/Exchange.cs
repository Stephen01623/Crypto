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
    public partial class Exchange : Form
    {
        public Exchange()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tboxex_TextChanged(object sender, EventArgs e)
        {
            if (cbox1.SelectedIndex == 1)
            {
                if (int.TryParse(tboxex.Text, out int value))
                {
                    reclb.Text = (value * 2).ToString();
                }
                else
                {
                    reclb.Text = "Invalid input";
                }
            }
            else if (cbox1.SelectedIndex == 0)
            {
                if (int.TryParse(tboxex.Text, out int value))
                {
                    reclb.Text = (value * 1).ToString();
                }
                else
                {
                    reclb.Text = "Invalid input";
                }
            }
            else if (cbox1.SelectedIndex == 2)
            {
                if (int.TryParse(tboxex.Text, out int value))
                {
                    reclb.Text = (value * 3).ToString();
                }
                else
                {
                    reclb.Text = "Invalid input";
                }
            }
            else if (cbox1.SelectedIndex == 3)
            {
                if (int.TryParse(tboxex.Text, out int value))
                {
                    reclb.Text = (value * 4).ToString();
                }
                else
                {
                    reclb.Text = "Invalid input";
                }
            }


        }

        private void dashpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
