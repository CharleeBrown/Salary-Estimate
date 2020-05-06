namespace SalaryEstimate_Desktop
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
            this.calculateAmount = new System.Windows.Forms.Button();
            this.hourRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grossAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.yearButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mainHourRate = new System.Windows.Forms.TextBox();
            this.mainYearAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.perCheckAmount = new System.Windows.Forms.TextBox();
            this.mainMonthAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateAmount
            // 
            this.calculateAmount.Location = new System.Drawing.Point(53, 79);
            this.calculateAmount.Name = "calculateAmount";
            this.calculateAmount.Size = new System.Drawing.Size(89, 36);
            this.calculateAmount.TabIndex = 0;
            this.calculateAmount.Text = "Calculate";
            this.calculateAmount.UseVisualStyleBackColor = true;
            this.calculateAmount.Click += new System.EventHandler(this.button1_Click);
            // 
            // hourRate
            // 
            this.hourRate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourRate.Location = new System.Drawing.Point(38, 34);
            this.hourRate.Name = "hourRate";
            this.hourRate.Size = new System.Drawing.Size(112, 21);
            this.hourRate.TabIndex = 1;
            this.hourRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hourRate.TextChanged += new System.EventHandler(this.hourRate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Hourly Rate";
            // 
            // grossAmount
            // 
            this.grossAmount.Enabled = false;
            this.grossAmount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossAmount.Location = new System.Drawing.Point(38, 145);
            this.grossAmount.Name = "grossAmount";
            this.grossAmount.Size = new System.Drawing.Size(112, 21);
            this.grossAmount.TabIndex = 4;
            this.grossAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gross Paycheck";
            // 
            // monthAmount
            // 
            this.monthAmount.Enabled = false;
            this.monthAmount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthAmount.Location = new System.Drawing.Point(38, 206);
            this.monthAmount.Name = "monthAmount";
            this.monthAmount.Size = new System.Drawing.Size(112, 21);
            this.monthAmount.TabIndex = 6;
            this.monthAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monthly Amount";
            // 
            // yearAmount
            // 
            this.yearAmount.Enabled = false;
            this.yearAmount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearAmount.Location = new System.Drawing.Point(38, 267);
            this.yearAmount.Name = "yearAmount";
            this.yearAmount.Size = new System.Drawing.Size(112, 21);
            this.yearAmount.TabIndex = 8;
            this.yearAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yearly Amount";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(215, 347);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.calculateAmount);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.hourRate);
            this.tabPage1.Controls.Add(this.yearAmount);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.grossAmount);
            this.tabPage1.Controls.Add(this.monthAmount);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(207, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculate Yearly";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.yearButton);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.mainHourRate);
            this.tabPage2.Controls.Add(this.mainYearAmount);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.perCheckAmount);
            this.tabPage2.Controls.Add(this.mainMonthAmount);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(207, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculate Hourly";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // yearButton
            // 
            this.yearButton.Location = new System.Drawing.Point(53, 79);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(89, 36);
            this.yearButton.TabIndex = 10;
            this.yearButton.Text = "Calculate";
            this.yearButton.UseVisualStyleBackColor = true;
            this.yearButton.Click += new System.EventHandler(this.yearButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Enter Salary";
            // 
            // mainHourRate
            // 
            this.mainHourRate.Enabled = false;
            this.mainHourRate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHourRate.Location = new System.Drawing.Point(38, 267);
            this.mainHourRate.Name = "mainHourRate";
            this.mainHourRate.Size = new System.Drawing.Size(119, 21);
            this.mainHourRate.TabIndex = 11;
            this.mainHourRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainYearAmount
            // 
            this.mainYearAmount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainYearAmount.Location = new System.Drawing.Point(38, 34);
            this.mainYearAmount.Name = "mainYearAmount";
            this.mainYearAmount.Size = new System.Drawing.Size(119, 21);
            this.mainYearAmount.TabIndex = 17;
            this.mainYearAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainYearAmount.TextChanged += new System.EventHandler(this.mainYearAmount_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hourly Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Monthly Amount";
            // 
            // perCheckAmount
            // 
            this.perCheckAmount.Enabled = false;
            this.perCheckAmount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perCheckAmount.Location = new System.Drawing.Point(38, 206);
            this.perCheckAmount.Name = "perCheckAmount";
            this.perCheckAmount.Size = new System.Drawing.Size(119, 21);
            this.perCheckAmount.TabIndex = 13;
            this.perCheckAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainMonthAmount
            // 
            this.mainMonthAmount.Enabled = false;
            this.mainMonthAmount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMonthAmount.Location = new System.Drawing.Point(38, 145);
            this.mainMonthAmount.Name = "mainMonthAmount";
            this.mainMonthAmount.Size = new System.Drawing.Size(119, 21);
            this.mainMonthAmount.TabIndex = 15;
            this.mainMonthAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Gross Paycheck";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 359);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Paycheck Estimator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calculateAmount;
        private System.Windows.Forms.TextBox hourRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox grossAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox monthAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yearAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button yearButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mainHourRate;
        private System.Windows.Forms.TextBox mainYearAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox perCheckAmount;
        private System.Windows.Forms.TextBox mainMonthAmount;
        private System.Windows.Forms.Label label8;
    }
}

