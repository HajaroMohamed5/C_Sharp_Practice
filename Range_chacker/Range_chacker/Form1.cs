using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_chacker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(txtNumber.Text, out number))
            {
                if (number >= 1 && number <= 10)
                {
                    lblResult.Text = "Number is in the valid range.";
                }
                else
                {
                    lblResult.Text = "Number is out of range.";
                }
            }
            else
            {
                lblResult.Text = "Please enter a valid integer.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            lblResult.Text = "";
            txtNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
