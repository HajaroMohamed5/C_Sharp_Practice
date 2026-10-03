using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltextscore3_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double score1;
            double score2;
            double score3;
            double average;

            score1 = double.Parse(txtScore1.Text);
            score2 = double.Parse(txtScore2.Text);
            score3 = double.Parse(txtScore3.Text);

            average = (score1 + score2 + score3) / 3;

            if (average >= 90)
            {
                lblaverage.Text = average.ToString("0.0");
            }
            else if (average >= 80)
            {
                lblaverage.Text = average.ToString("0.0");
            }
            else if (average >= 70)
            {
                lblaverage.Text = average.ToString("0.0");
            }
            else if (average >= 60)
            {
                lblaverage.Text = average.ToString("0.0");
            }
            else
            {
                lblaverage.Text = average.ToString("0.0");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
            lblaverage.Text = "";
            txtScore1.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

