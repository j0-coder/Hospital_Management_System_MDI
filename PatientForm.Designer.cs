namespace Hospital_Management_System_MDI
{
    partial class PatientForm
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
            this.PatientInformationLabel = new System.Windows.Forms.Label();
            this.PatientIcon = new System.Windows.Forms.PictureBox();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.PatientNameField = new System.Windows.Forms.TextBox();
            this.PatientAgeLabel = new System.Windows.Forms.Label();
            this.PatientAgeField = new System.Windows.Forms.TextBox();
            this.PatientAddressLabel = new System.Windows.Forms.Label();
            this.PatientAddressField = new System.Windows.Forms.TextBox();
            this.PatientDiagnosisLabel = new System.Windows.Forms.Label();
            this.PatientDiagnosisField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PatientIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientInformationLabel
            // 
            this.PatientInformationLabel.AutoSize = true;
            this.PatientInformationLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientInformationLabel.Location = new System.Drawing.Point(91, 19);
            this.PatientInformationLabel.Name = "PatientInformationLabel";
            this.PatientInformationLabel.Size = new System.Drawing.Size(194, 25);
            this.PatientInformationLabel.TabIndex = 0;
            this.PatientInformationLabel.Text = "Patient\'s Information";
            // 
            // PatientIcon
            // 
            this.PatientIcon.Image = global::Hospital_Management_System_MDI.Properties.Resources.man_with_hay_fever_svgrepo_com;
            this.PatientIcon.Location = new System.Drawing.Point(136, 52);
            this.PatientIcon.Name = "PatientIcon";
            this.PatientIcon.Size = new System.Drawing.Size(100, 100);
            this.PatientIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PatientIcon.TabIndex = 1;
            this.PatientIcon.TabStop = false;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLabel.Location = new System.Drawing.Point(54, 181);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(102, 20);
            this.PatientNameLabel.TabIndex = 2;
            this.PatientNameLabel.Text = "Patient Name:";
            // 
            // PatientNameField
            // 
            this.PatientNameField.BackColor = System.Drawing.Color.Ivory;
            this.PatientNameField.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameField.Location = new System.Drawing.Point(160, 179);
            this.PatientNameField.Name = "PatientNameField";
            this.PatientNameField.Size = new System.Drawing.Size(154, 27);
            this.PatientNameField.TabIndex = 3;
            // 
            // PatientAgeLabel
            // 
            this.PatientAgeLabel.AutoSize = true;
            this.PatientAgeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAgeLabel.Location = new System.Drawing.Point(54, 214);
            this.PatientAgeLabel.Name = "PatientAgeLabel";
            this.PatientAgeLabel.Size = new System.Drawing.Size(39, 20);
            this.PatientAgeLabel.TabIndex = 2;
            this.PatientAgeLabel.Text = "Age:";
            // 
            // PatientAgeField
            // 
            this.PatientAgeField.BackColor = System.Drawing.Color.Ivory;
            this.PatientAgeField.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAgeField.Location = new System.Drawing.Point(160, 212);
            this.PatientAgeField.Name = "PatientAgeField";
            this.PatientAgeField.Size = new System.Drawing.Size(154, 27);
            this.PatientAgeField.TabIndex = 3;
            // 
            // PatientAddressLabel
            // 
            this.PatientAddressLabel.AutoSize = true;
            this.PatientAddressLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAddressLabel.Location = new System.Drawing.Point(54, 247);
            this.PatientAddressLabel.Name = "PatientAddressLabel";
            this.PatientAddressLabel.Size = new System.Drawing.Size(65, 20);
            this.PatientAddressLabel.TabIndex = 2;
            this.PatientAddressLabel.Text = "Address:";
            // 
            // PatientAddressField
            // 
            this.PatientAddressField.BackColor = System.Drawing.Color.Ivory;
            this.PatientAddressField.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAddressField.Location = new System.Drawing.Point(160, 245);
            this.PatientAddressField.Name = "PatientAddressField";
            this.PatientAddressField.Size = new System.Drawing.Size(154, 27);
            this.PatientAddressField.TabIndex = 3;
            // 
            // PatientDiagnosisLabel
            // 
            this.PatientDiagnosisLabel.AutoSize = true;
            this.PatientDiagnosisLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientDiagnosisLabel.Location = new System.Drawing.Point(54, 280);
            this.PatientDiagnosisLabel.Name = "PatientDiagnosisLabel";
            this.PatientDiagnosisLabel.Size = new System.Drawing.Size(77, 20);
            this.PatientDiagnosisLabel.TabIndex = 2;
            this.PatientDiagnosisLabel.Text = "Diagnosis:";
            // 
            // PatientDiagnosisField
            // 
            this.PatientDiagnosisField.BackColor = System.Drawing.Color.Ivory;
            this.PatientDiagnosisField.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientDiagnosisField.Location = new System.Drawing.Point(160, 278);
            this.PatientDiagnosisField.Name = "PatientDiagnosisField";
            this.PatientDiagnosisField.Size = new System.Drawing.Size(154, 27);
            this.PatientDiagnosisField.TabIndex = 3;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.PatientDiagnosisField);
            this.Controls.Add(this.PatientDiagnosisLabel);
            this.Controls.Add(this.PatientAddressField);
            this.Controls.Add(this.PatientAddressLabel);
            this.Controls.Add(this.PatientAgeField);
            this.Controls.Add(this.PatientAgeLabel);
            this.Controls.Add(this.PatientNameField);
            this.Controls.Add(this.PatientNameLabel);
            this.Controls.Add(this.PatientIcon);
            this.Controls.Add(this.PatientInformationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PatientForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.PatientIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatientInformationLabel;
        private System.Windows.Forms.PictureBox PatientIcon;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.TextBox PatientNameField;
        private System.Windows.Forms.Label PatientAgeLabel;
        private System.Windows.Forms.TextBox PatientAgeField;
        private System.Windows.Forms.Label PatientAddressLabel;
        private System.Windows.Forms.TextBox PatientAddressField;
        private System.Windows.Forms.Label PatientDiagnosisLabel;
        private System.Windows.Forms.TextBox PatientDiagnosisField;
    }
}