namespace Hotel_Room_Booking_Calculator
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
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtNumberofNights = new System.Windows.Forms.Label();
            this.txtPricePerNight = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtPriceNight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblServiceTax = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.ForeColor = System.Drawing.Color.Black;
            this.lblGuestName.Location = new System.Drawing.Point(75, 37);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(130, 13);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "Enter Guest Name    :";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.ForeColor = System.Drawing.Color.Black;
            this.lblRoomType.Location = new System.Drawing.Point(75, 83);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(121, 13);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "Enter Room Type   :";
            this.lblRoomType.UseWaitCursor = true;
            // 
            // txtNumberofNights
            // 
            this.txtNumberofNights.AutoSize = true;
            this.txtNumberofNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberofNights.ForeColor = System.Drawing.Color.Black;
            this.txtNumberofNights.Location = new System.Drawing.Point(75, 132);
            this.txtNumberofNights.Name = "txtNumberofNights";
            this.txtNumberofNights.Size = new System.Drawing.Size(159, 13);
            this.txtNumberofNights.TabIndex = 2;
            this.txtNumberofNights.Text = "Enter Number of Nights:   :";
            // 
            // txtPricePerNight
            // 
            this.txtPricePerNight.AutoSize = true;
            this.txtPricePerNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerNight.ForeColor = System.Drawing.Color.Black;
            this.txtPricePerNight.Location = new System.Drawing.Point(75, 187);
            this.txtPricePerNight.Name = "txtPricePerNight";
            this.txtPricePerNight.Size = new System.Drawing.Size(143, 13);
            this.txtPricePerNight.TabIndex = 3;
            this.txtPricePerNight.Text = "Enter Price Per Night   :";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(437, 30);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(100, 20);
            this.txtGuestName.TabIndex = 8;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(437, 80);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(100, 20);
            this.txtRoomType.TabIndex = 9;
            this.txtRoomType.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(437, 125);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(100, 20);
            this.txtNights.TabIndex = 10;
            // 
            // txtPriceNight
            // 
            this.txtPriceNight.Location = new System.Drawing.Point(437, 180);
            this.txtPriceNight.Name = "txtPriceNight";
            this.txtPriceNight.Size = new System.Drawing.Size(100, 20);
            this.txtPriceNight.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(319, 222);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(151, 53);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculating Booking";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Service Tax (10%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Discount (5%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Total Amount";
            // 
            // lblServiceTax
            // 
            this.lblServiceTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServiceTax.Location = new System.Drawing.Point(434, 301);
            this.lblServiceTax.Name = "lblServiceTax";
            this.lblServiceTax.Size = new System.Drawing.Size(130, 22);
            this.lblServiceTax.TabIndex = 22;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscount.Location = new System.Drawing.Point(435, 350);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(129, 30);
            this.lblDiscount.TabIndex = 23;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmount.Location = new System.Drawing.Point(435, 393);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(129, 35);
            this.lblTotalAmount.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblServiceTax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPriceNight);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.txtPricePerNight);
            this.Controls.Add(this.txtNumberofNights);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblGuestName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label txtNumberofNights;
        private System.Windows.Forms.Label txtPricePerNight;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtPriceNight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblServiceTax;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}

