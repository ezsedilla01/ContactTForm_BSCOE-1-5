namespace ContacTracingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxGivenName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.txtBoxCurrentAddress = new System.Windows.Forms.TextBox();
            this.txtBoxCurrentAddress1 = new System.Windows.Forms.TextBox();
            this.txtBoxTimeofVisit = new System.Windows.Forms.TextBox();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.txtBoxSignatureFPN = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Submitbuttonclick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact Tracing Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Given Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Current Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Time of Visit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Signature (Full Printed Name)";
            // 
            // txtBoxGivenName
            // 
            this.txtBoxGivenName.Location = new System.Drawing.Point(204, 58);
            this.txtBoxGivenName.Name = "txtBoxGivenName";
            this.txtBoxGivenName.Size = new System.Drawing.Size(125, 27);
            this.txtBoxGivenName.TabIndex = 10;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(204, 102);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(125, 27);
            this.txtBoxLastName.TabIndex = 11;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(223, 148);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(165, 27);
            this.txtBoxPhoneNumber.TabIndex = 12;
            // 
            // txtBoxEmailAddress
            // 
            this.txtBoxEmailAddress.Location = new System.Drawing.Point(223, 197);
            this.txtBoxEmailAddress.Name = "txtBoxEmailAddress";
            this.txtBoxEmailAddress.Size = new System.Drawing.Size(165, 27);
            this.txtBoxEmailAddress.TabIndex = 13;
            // 
            // txtBoxCurrentAddress
            // 
            this.txtBoxCurrentAddress.Location = new System.Drawing.Point(223, 250);
            this.txtBoxCurrentAddress.Name = "txtBoxCurrentAddress";
            this.txtBoxCurrentAddress.Size = new System.Drawing.Size(323, 27);
            this.txtBoxCurrentAddress.TabIndex = 14;
            // 
            // txtBoxCurrentAddress1
            // 
            this.txtBoxCurrentAddress1.Location = new System.Drawing.Point(223, 283);
            this.txtBoxCurrentAddress1.Name = "txtBoxCurrentAddress1";
            this.txtBoxCurrentAddress1.Size = new System.Drawing.Size(323, 27);
            this.txtBoxCurrentAddress1.TabIndex = 15;
            // 
            // txtBoxTimeofVisit
            // 
            this.txtBoxTimeofVisit.Location = new System.Drawing.Point(223, 338);
            this.txtBoxTimeofVisit.Name = "txtBoxTimeofVisit";
            this.txtBoxTimeofVisit.Size = new System.Drawing.Size(125, 27);
            this.txtBoxTimeofVisit.TabIndex = 16;
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(165, 384);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(183, 27);
            this.txtBoxDate.TabIndex = 17;
            // 
            // txtBoxSignatureFPN
            // 
            this.txtBoxSignatureFPN.Location = new System.Drawing.Point(306, 442);
            this.txtBoxSignatureFPN.Name = "txtBoxSignatureFPN";
            this.txtBoxSignatureFPN.Size = new System.Drawing.Size(240, 27);
            this.txtBoxSignatureFPN.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Cancelbuttonclick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 563);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBoxSignatureFPN);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.txtBoxTimeofVisit);
            this.Controls.Add(this.txtBoxCurrentAddress1);
            this.Controls.Add(this.txtBoxCurrentAddress);
            this.Controls.Add(this.txtBoxEmailAddress);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxGivenName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Contact Tracing App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtBoxGivenName;
        private TextBox txtBoxLastName;
        private TextBox txtBoxPhoneNumber;
        private TextBox txtBoxEmailAddress;
        private TextBox txtBoxCurrentAddress;
        private TextBox txtBoxCurrentAddress1;
        private TextBox txtBoxTimeofVisit;
        private TextBox txtBoxDate;
        private TextBox txtBoxSignatureFPN;
        private Button button2;
    }
}