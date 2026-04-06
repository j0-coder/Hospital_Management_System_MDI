namespace Hospital_Management_System_MDI
{
    partial class BillingForm
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
            this.DoctorSpecializationField = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.DoctorNameField = new System.Windows.Forms.TextBox();
            this.DoctorNameLabel = new System.Windows.Forms.Label();
            this.DoctorIcon = new System.Windows.Forms.PictureBox();
            this.BillingInformationLabel = new System.Windows.Forms.Label();
            this.PaymentStatusLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // DoctorSpecializationField
            // 
            this.DoctorSpecializationField.BackColor = System.Drawing.Color.Ivory;
            this.DoctorSpecializationField.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorSpecializationField.Location = new System.Drawing.Point(177, 220);
            this.DoctorSpecializationField.Name = "DoctorSpecializationField";
            this.DoctorSpecializationField.Size = new System.Drawing.Size(154, 27);
            this.DoctorSpecializationField.TabIndex = 18;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(59, 223);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(65, 20);
            this.AmountLabel.TabIndex = 16;
            this.AmountLabel.Text = "Amount:";
            // 
            // DoctorNameField
            // 
            this.DoctorNameField.BackColor = System.Drawing.Color.Ivory;
            this.DoctorNameField.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorNameField.Location = new System.Drawing.Point(177, 187);
            this.DoctorNameField.Name = "DoctorNameField";
            this.DoctorNameField.Size = new System.Drawing.Size(154, 27);
            this.DoctorNameField.TabIndex = 19;
            // 
            // DoctorNameLabel
            // 
            this.DoctorNameLabel.AutoSize = true;
            this.DoctorNameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorNameLabel.Location = new System.Drawing.Point(59, 190);
            this.DoctorNameLabel.Name = "DoctorNameLabel";
            this.DoctorNameLabel.Size = new System.Drawing.Size(102, 20);
            this.DoctorNameLabel.TabIndex = 17;
            this.DoctorNameLabel.Text = "Patient Name:";
            // 
            // DoctorIcon
            // 
            this.DoctorIcon.Image = global::Hospital_Management_System_MDI.Properties.Resources.envelopes_and_documents_svgrepo_com;
            this.DoctorIcon.Location = new System.Drawing.Point(141, 61);
            this.DoctorIcon.Name = "DoctorIcon";
            this.DoctorIcon.Size = new System.Drawing.Size(100, 100);
            this.DoctorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DoctorIcon.TabIndex = 15;
            this.DoctorIcon.TabStop = false;
            // 
            // BillingInformationLabel
            // 
            this.BillingInformationLabel.AutoSize = true;
            this.BillingInformationLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingInformationLabel.Location = new System.Drawing.Point(105, 29);
            this.BillingInformationLabel.Name = "BillingInformationLabel";
            this.BillingInformationLabel.Size = new System.Drawing.Size(173, 25);
            this.BillingInformationLabel.TabIndex = 14;
            this.BillingInformationLabel.Text = "Billing Information";
            // 
            // PaymentStatusLabel
            // 
            this.PaymentStatusLabel.AutoSize = true;
            this.PaymentStatusLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentStatusLabel.Location = new System.Drawing.Point(59, 256);
            this.PaymentStatusLabel.Name = "PaymentStatusLabel";
            this.PaymentStatusLabel.Size = new System.Drawing.Size(113, 20);
            this.PaymentStatusLabel.TabIndex = 16;
            this.PaymentStatusLabel.Text = "Payment Status:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Ivory;
            this.textBox1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(177, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 27);
            this.textBox1.TabIndex = 18;
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PaymentStatusLabel);
            this.Controls.Add(this.DoctorSpecializationField);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.DoctorNameField);
            this.Controls.Add(this.DoctorNameLabel);
            this.Controls.Add(this.DoctorIcon);
            this.Controls.Add(this.BillingInformationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BillingForm";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.DoctorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DoctorSpecializationField;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox DoctorNameField;
        private System.Windows.Forms.Label DoctorNameLabel;
        private System.Windows.Forms.PictureBox DoctorIcon;
        private System.Windows.Forms.Label BillingInformationLabel;
        private System.Windows.Forms.Label PaymentStatusLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}