namespace Home__Assingnment_CA242
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbldayoftherweek = new System.Windows.Forms.Label();
            this.lblnameofthemonth = new System.Windows.Forms.Label();
            this.lblnumericmonth = new System.Windows.Forms.Label();
            this.lbltheyear = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtDayoftheweek = new System.Windows.Forms.TextBox();
            this.txtdateofthemoth = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.btnshowdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldayoftherweek
            // 
            this.lbldayoftherweek.AutoSize = true;
            this.lbldayoftherweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayoftherweek.Location = new System.Drawing.Point(63, 52);
            this.lbldayoftherweek.Name = "lbldayoftherweek";
            this.lbldayoftherweek.Size = new System.Drawing.Size(189, 20);
            this.lbldayoftherweek.TabIndex = 0;
            this.lbldayoftherweek.Text = "Enter day of the week:";
            // 
            // lblnameofthemonth
            // 
            this.lblnameofthemonth.AutoSize = true;
            this.lblnameofthemonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameofthemonth.Location = new System.Drawing.Point(43, 105);
            this.lblnameofthemonth.Name = "lblnameofthemonth";
            this.lblnameofthemonth.Size = new System.Drawing.Size(214, 20);
            this.lblnameofthemonth.TabIndex = 1;
            this.lblnameofthemonth.Text = "Enter name of the month:";
            // 
            // lblnumericmonth
            // 
            this.lblnumericmonth.AutoSize = true;
            this.lblnumericmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumericmonth.Location = new System.Drawing.Point(3, 148);
            this.lblnumericmonth.Name = "lblnumericmonth";
            this.lblnumericmonth.Size = new System.Drawing.Size(249, 20);
            this.lblnumericmonth.TabIndex = 2;
            this.lblnumericmonth.Text = "Enter the numeric of the moth";
            // 
            // lbltheyear
            // 
            this.lbltheyear.AutoSize = true;
            this.lbltheyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltheyear.Location = new System.Drawing.Point(89, 198);
            this.lbltheyear.Name = "lbltheyear";
            this.lbltheyear.Size = new System.Drawing.Size(127, 20);
            this.lbltheyear.TabIndex = 3;
            this.lbltheyear.Text = "Enter the Year";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(93, 281);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(563, 49);
            this.lbloutput.TabIndex = 4;
            this.lbloutput.Click += new System.EventHandler(this.lbloutput_Click);
            // 
            // txtDayoftheweek
            // 
            this.txtDayoftheweek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDayoftheweek.Location = new System.Drawing.Point(420, 63);
            this.txtDayoftheweek.Name = "txtDayoftheweek";
            this.txtDayoftheweek.Size = new System.Drawing.Size(281, 20);
            this.txtDayoftheweek.TabIndex = 5;
            this.txtDayoftheweek.TextChanged += new System.EventHandler(this.txtDayoftheweek_TextChanged);
            // 
            // txtdateofthemoth
            // 
            this.txtdateofthemoth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdateofthemoth.Location = new System.Drawing.Point(420, 112);
            this.txtdateofthemoth.Name = "txtdateofthemoth";
            this.txtdateofthemoth.Size = new System.Drawing.Size(281, 20);
            this.txtdateofthemoth.TabIndex = 6;
            // 
            // txtmonth
            // 
            this.txtmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmonth.Location = new System.Drawing.Point(420, 153);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(281, 20);
            this.txtmonth.TabIndex = 7;
            // 
            // txtyear
            // 
            this.txtyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyear.Location = new System.Drawing.Point(420, 199);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(281, 20);
            this.txtyear.TabIndex = 8;
            // 
            // btnshowdate
            // 
            this.btnshowdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowdate.Location = new System.Drawing.Point(131, 356);
            this.btnshowdate.Name = "btnshowdate";
            this.btnshowdate.Size = new System.Drawing.Size(85, 34);
            this.btnshowdate.TabIndex = 9;
            this.btnshowdate.Text = "Show Date";
            this.btnshowdate.UseVisualStyleBackColor = true;
            this.btnshowdate.Click += new System.EventHandler(this.btnshowdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(337, 356);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(93, 34);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(507, 356);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(112, 34);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowdate);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtdateofthemoth);
            this.Controls.Add(this.txtDayoftheweek);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lbltheyear);
            this.Controls.Add(this.lblnumericmonth);
            this.Controls.Add(this.lblnameofthemonth);
            this.Controls.Add(this.lbldayoftherweek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldayoftherweek;
        private System.Windows.Forms.Label lblnameofthemonth;
        private System.Windows.Forms.Label lblnumericmonth;
        private System.Windows.Forms.Label lbltheyear;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtDayoftheweek;
        private System.Windows.Forms.TextBox txtdateofthemoth;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Button btnshowdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

