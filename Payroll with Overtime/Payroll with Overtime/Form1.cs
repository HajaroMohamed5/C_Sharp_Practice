using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double hours;
            double payRate;
            double grossPay;

            hours = double.Parse(txthoursWorked.Text);
            payRate = double.Parse(txthourlyPayRate.Text);

            if (hours <= 40)
            {
                grossPay = hours * payRate;
            }
            else
            {
                double overtimeHours;
                double overtimePay;

                overtimeHours = hours - 40;
                overtimePay = overtimeHours * payRate * 1.5;

                grossPay = (40 * payRate) + overtimePay;
            }

            lblgrossPay.Text = grossPay.ToString("C");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txthoursWorked.Clear();
            txthourlyPayRate.Clear();
            lblgrossPay.Text = "";
            txthoursWorked.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
