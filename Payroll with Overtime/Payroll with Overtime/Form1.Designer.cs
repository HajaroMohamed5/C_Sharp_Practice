namespace Payroll_with_Overtime
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
            this.lblhoursWorked = new System.Windows.Forms.Label();
            this.lblhourlyPayRate = new System.Windows.Forms.Label();
            this.lblgrossPayTitle = new System.Windows.Forms.Label();
            this.txthoursWorked = new System.Windows.Forms.TextBox();
            this.txthourlyPayRate = new System.Windows.Forms.TextBox();
            this.lblgrossPay = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhoursWorked
            // 
            this.lblhoursWorked.AutoSize = true;
            this.lblhoursWorked.Location = new System.Drawing.Point(182, 51);
            this.lblhoursWorked.Name = "lblhoursWorked";
            this.lblhoursWorked.Size = new System.Drawing.Size(82, 13);
            this.lblhoursWorked.TabIndex = 0;
            this.lblhoursWorked.Text = "Hours worked  :";
            // 
            // lblhourlyPayRate
            // 
            this.lblhourlyPayRate.AutoSize = true;
            this.lblhourlyPayRate.Location = new System.Drawing.Point(182, 98);
            this.lblhourlyPayRate.Name = "lblhourlyPayRate";
            this.lblhourlyPayRate.Size = new System.Drawing.Size(84, 13);
            this.lblhourlyPayRate.TabIndex = 1;
            this.lblhourlyPayRate.Text = "Hourly pay rate :";
            // 
            // lblgrossPayTitle
            // 
            this.lblgrossPayTitle.AutoSize = true;
            this.lblgrossPayTitle.Location = new System.Drawing.Point(182, 140);
            this.lblgrossPayTitle.Name = "lblgrossPayTitle";
            this.lblgrossPayTitle.Size = new System.Drawing.Size(60, 13);
            this.lblgrossPayTitle.TabIndex = 2;
            this.lblgrossPayTitle.Text = "Gross pay :";
            // 
            // txthoursWorked
            // 
            this.txthoursWorked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoursWorked.Location = new System.Drawing.Point(324, 51);
            this.txthoursWorked.Name = "txthoursWorked";
            this.txthoursWorked.Size = new System.Drawing.Size(100, 21);
            this.txthoursWorked.TabIndex = 3;
            // 
            // txthourlyPayRate
            // 
            this.txthourlyPayRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthourlyPayRate.Location = new System.Drawing.Point(324, 95);
            this.txthourlyPayRate.Name = "txthourlyPayRate";
            this.txthourlyPayRate.Size = new System.Drawing.Size(100, 20);
            this.txthourlyPayRate.TabIndex = 4;
            // 
            // lblgrossPay
            // 
            this.lblgrossPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblgrossPay.Location = new System.Drawing.Point(324, 140);
            this.lblgrossPay.Name = "lblgrossPay";
            this.lblgrossPay.Size = new System.Drawing.Size(100, 23);
            this.lblgrossPay.TabIndex = 5;
            // 
            // btncalculate
            // 
            this.btncalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncalculate.Location = new System.Drawing.Point(176, 268);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(101, 41);
            this.btncalculate.TabIndex = 6;
            this.btncalculate.Text = "Calculate Gross Pay";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Location = new System.Drawing.Point(313, 268);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(98, 41);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Location = new System.Drawing.Point(443, 268);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(103, 41);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblgrossPay);
            this.Controls.Add(this.txthourlyPayRate);
            this.Controls.Add(this.txthoursWorked);
            this.Controls.Add(this.lblgrossPayTitle);
            this.Controls.Add(this.lblhourlyPayRate);
            this.Controls.Add(this.lblhoursWorked);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhoursWorked;
        private System.Windows.Forms.Label lblhourlyPayRate;
        private System.Windows.Forms.Label lblgrossPayTitle;
        private System.Windows.Forms.TextBox txthoursWorked;
        private System.Windows.Forms.TextBox txthourlyPayRate;
        private System.Windows.Forms.Label lblgrossPay;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

