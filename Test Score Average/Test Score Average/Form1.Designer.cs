namespace Test_Score_Average
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblaverage = new System.Windows.Forms.Label();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.lblavrg = new System.Windows.Forms.Label();
            this.lbltextscore3 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblaverage);
            this.groupBox1.Controls.Add(this.txtScore3);
            this.groupBox1.Controls.Add(this.txtScore2);
            this.groupBox1.Controls.Add(this.txtScore1);
            this.groupBox1.Controls.Add(this.lblavrg);
            this.groupBox1.Controls.Add(this.lbltextscore3);
            this.groupBox1.Controls.Add(this.lblScore2);
            this.groupBox1.Controls.Add(this.lblScore1);
            this.groupBox1.Location = new System.Drawing.Point(32, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Three Test Scores";
            // 
            // lblaverage
            // 
            this.lblaverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblaverage.Location = new System.Drawing.Point(189, 153);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(103, 22);
            this.lblaverage.TabIndex = 7;
            // 
            // txtScore3
            // 
            this.txtScore3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScore3.Location = new System.Drawing.Point(192, 120);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(100, 20);
            this.txtScore3.TabIndex = 6;
            // 
            // txtScore2
            // 
            this.txtScore2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScore2.Location = new System.Drawing.Point(192, 74);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(100, 20);
            this.txtScore2.TabIndex = 5;
            // 
            // txtScore1
            // 
            this.txtScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScore1.Location = new System.Drawing.Point(192, 38);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(100, 20);
            this.txtScore1.TabIndex = 4;
            this.txtScore1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblavrg
            // 
            this.lblavrg.AutoSize = true;
            this.lblavrg.Location = new System.Drawing.Point(62, 153);
            this.lblavrg.Name = "lblavrg";
            this.lblavrg.Size = new System.Drawing.Size(47, 13);
            this.lblavrg.TabIndex = 2;
            this.lblavrg.Text = "Average";
            // 
            // lbltextscore3
            // 
            this.lbltextscore3.AutoSize = true;
            this.lbltextscore3.Location = new System.Drawing.Point(62, 120);
            this.lbltextscore3.Name = "lbltextscore3";
            this.lbltextscore3.Size = new System.Drawing.Size(65, 13);
            this.lbltextscore3.TabIndex = 3;
            this.lbltextscore3.Text = "Text Score3";
            this.lbltextscore3.Click += new System.EventHandler(this.lbltextscore3_Click);
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Location = new System.Drawing.Point(62, 74);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(75, 13);
            this.lblScore2.TabIndex = 2;
            this.lblScore2.Text = "Test Score #2";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Location = new System.Drawing.Point(62, 38);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(75, 13);
            this.lblScore1.TabIndex = 1;
            this.lblScore1.Text = "Test Score #1";
            this.lblScore1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(314, 338);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(117, 64);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "Calculate Average";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(490, 321);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(94, 31);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Location = new System.Drawing.Point(490, 369);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(94, 33);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblavrg;
        private System.Windows.Forms.Label lbltextscore3;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.Label lblaverage;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

