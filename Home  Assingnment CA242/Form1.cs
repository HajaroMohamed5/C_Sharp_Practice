using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home__Assingnment_CA242
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

        private void btnshowdate_Click(object sender, EventArgs e)
        {
            //creating a variables 
            string dayof_week,Name_of_the_Month, Numeric_Day, Year, Full_Date;

            //
            dayof_week = txtDayoftheweek.Text;
            Name_of_the_Month = txtdateofthemoth.Text;
            Numeric_Day = txtmonth.Text;
            Year = txtyear.Text;

            // stage 2
             Full_Date = dayof_week + " , " +Name_of_the_Month + "," +
                Numeric_Day + "," + Year;


            //stage3 = the output using label

            lbloutput.Text = Full_Date;


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing textbox and label

            txtDayoftheweek.Clear();
            txtdateofthemoth.Text = "";
            txtmonth.Text = string. Empty;
            txtyear.Clear();
            lbloutput.Text = "";

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //form close - using this keyword and close funtion
            this.Close();

        }

        private void txtDayoftheweek_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbloutput_Click(object sender, EventArgs e)
        {

        }
    }
}
