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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GivenNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.CurrentAddressLabel = new System.Windows.Forms.Label();
            this.TimeofVisitLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SignatureFPNLabel = new System.Windows.Forms.Label();
            this.txtBoxGivenName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.txtBoxCurrentAddress = new System.Windows.Forms.TextBox();
            this.txtBoxCurrentAddress1 = new System.Windows.Forms.TextBox();
            this.txtBoxTimeofVisit = new System.Windows.Forms.TextBox();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.txtBoxSignatureFPN = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(452, 522);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(94, 29);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.Submitbuttonclick);
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
            // GivenNameLabel
            // 
            this.GivenNameLabel.AutoSize = true;
            this.GivenNameLabel.Location = new System.Drawing.Point(96, 61);
            this.GivenNameLabel.Name = "GivenNameLabel";
            this.GivenNameLabel.Size = new System.Drawing.Size(90, 20);
            this.GivenNameLabel.TabIndex = 2;
            this.GivenNameLabel.Text = "Given Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(97, 105);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(79, 20);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(98, 153);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(108, 20);
            this.PhoneNumberLabel.TabIndex = 4;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Location = new System.Drawing.Point(98, 197);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(103, 20);
            this.EmailAddressLabel.TabIndex = 5;
            this.EmailAddressLabel.Text = "Email Address";
            // 
            // CurrentAddressLabel
            // 
            this.CurrentAddressLabel.AutoSize = true;
            this.CurrentAddressLabel.Location = new System.Drawing.Point(98, 253);
            this.CurrentAddressLabel.Name = "CurrentAddressLabel";
            this.CurrentAddressLabel.Size = new System.Drawing.Size(114, 20);
            this.CurrentAddressLabel.TabIndex = 6;
            this.CurrentAddressLabel.Text = "Current Address";
            // 
            // TimeofVisitLabel
            // 
            this.TimeofVisitLabel.AutoSize = true;
            this.TimeofVisitLabel.Location = new System.Drawing.Point(96, 341);
            this.TimeofVisitLabel.Name = "TimeofVisitLabel";
            this.TimeofVisitLabel.Size = new System.Drawing.Size(92, 20);
            this.TimeofVisitLabel.TabIndex = 7;
            this.TimeofVisitLabel.Text = "Time of Visit";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(96, 391);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(41, 20);
            this.DateLabel.TabIndex = 8;
            this.DateLabel.Text = "Date";
            // 
            // SignatureFPNLabel
            // 
            this.SignatureFPNLabel.AutoSize = true;
            this.SignatureFPNLabel.Location = new System.Drawing.Point(96, 449);
            this.SignatureFPNLabel.Name = "SignatureFPNLabel";
            this.SignatureFPNLabel.Size = new System.Drawing.Size(204, 20);
            this.SignatureFPNLabel.TabIndex = 9;
            this.SignatureFPNLabel.Text = "Signature (Full Printed Name)";
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
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(343, 522);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 29);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancelbuttonclick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 563);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.txtBoxSignatureFPN);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.txtBoxTimeofVisit);
            this.Controls.Add(this.txtBoxCurrentAddress1);
            this.Controls.Add(this.txtBoxCurrentAddress);
            this.Controls.Add(this.txtBoxEmailAddress);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxGivenName);
            this.Controls.Add(this.SignatureFPNLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeofVisitLabel);
            this.Controls.Add(this.CurrentAddressLabel);
            this.Controls.Add(this.EmailAddressLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.GivenNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitButton);
            this.Name = "Form1";
            this.Text = "Contact Tracing App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SubmitButton;
        private Label label1;
        private Label GivenNameLabel;
        private Label LastNameLabel;
        private Label PhoneNumberLabel;
        private Label EmailAddressLabel;
        private Label CurrentAddressLabel;
        private Label TimeofVisitLabel;
        private Label DateLabel;
        private Label SignatureFPNLabel;
        private TextBox txtBoxGivenName;
        private TextBox txtBoxLastName;
        private TextBox txtBoxPhoneNumber;
        private TextBox txtBoxEmailAddress;
        private TextBox txtBoxCurrentAddress;
        private TextBox txtBoxCurrentAddress1;
        private TextBox txtBoxTimeofVisit;
        private TextBox txtBoxDate;
        private TextBox txtBoxSignatureFPN;
        private Button CancelButton;
    }
}