using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Booking_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                double nights = Convert.ToDouble(txtNights.Text);
                double price = Convert.ToDouble(txtPriceNight.Text);

                double subtotal = nights * price;
                double serviceTax = subtotal * 0.10;
                double discount = subtotal * 0.05;
                double totalAmount = subtotal + serviceTax - discount;

                // Qiimahan wuxuu si toos ah uga dhex muuqan doonaa label-yada midigta ku jira
                lblServiceTax.Text = "$" + serviceTax.ToString("F2");
                lblDiscount.Text = "$" + discount.ToString("F2");
                lblTotalAmount.Text = "$" + totalAmount.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fadlan geli nambarro sax ah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
