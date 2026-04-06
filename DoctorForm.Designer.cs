namespace Hospital_Management_System_MDI
{
    partial class DoctorForm
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
            this.DoctorNameField = new System.Windows.Forms.TextBox();
            this.DoctorNameLabel = new System.Windows.Forms.Label();
            this.DoctorIcon = new System.Windows.Forms.PictureBox();
            this.DoctorInformationLabel = new System.Windows.Forms.Label();
            this.DoctorSpecializationLabel = new System.Windows.Forms.Label();
            this.DoctorSpecializationField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // DoctorNameField
            // 
            this.DoctorNameField.BackColor = System.Drawing.Color.Ivory;
            this.DoctorNameField.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorNameField.Location = new System.Drawing.Point(167, 196);
            this.DoctorNameField.Name = "DoctorNameField";
            this.DoctorNameField.Size = new System.Drawing.Size(154, 27);
            this.DoctorNameField.TabIndex = 13;
            // 
            // DoctorNameLabel
            // 
            this.DoctorNameLabel.AutoSize = true;
            this.DoctorNameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorNameLabel.Location = new System.Drawing.Point(62, 199);
            this.DoctorNameLabel.Name = "DoctorNameLabel";
            this.DoctorNameLabel.Size = new System.Drawing.Size(102, 20);
            this.DoctorNameLabel.TabIndex = 9;
            this.DoctorNameLabel.Text = "Doctor Name:";
            // 
            // DoctorIcon
            // 
            this.DoctorIcon.Image = global::Hospital_Management_System_MDI.Properties.Resources.female_doctor_taking_an_ok_pose_svgrepo_com;
            this.DoctorIcon.Location = new System.Drawing.Point(144, 70);
            this.DoctorIcon.Name = "DoctorIcon";
            this.DoctorIcon.Size = new System.Drawing.Size(100, 100);
            this.DoctorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DoctorIcon.TabIndex = 5;
            this.DoctorIcon.TabStop = false;
            // 
            // DoctorInformationLabel
            // 
            this.DoctorInformationLabel.AutoSize = true;
            this.DoctorInformationLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorInformationLabel.Location = new System.Drawing.Point(99, 37);
            this.DoctorInformationLabel.Name = "DoctorInformationLabel";
            this.DoctorInformationLabel.Size = new System.Drawing.Size(192, 25);
            this.DoctorInformationLabel.TabIndex = 4;
            this.DoctorInformationLabel.Text = "Doctor\'s Information";
            // 
            // DoctorSpecializationLabel
            // 
            this.DoctorSpecializationLabel.AutoSize = true;
            this.DoctorSpecializationLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorSpecializationLabel.Location = new System.Drawing.Point(62, 232);
            this.DoctorSpecializationLabel.Name = "DoctorSpecializationLabel";
            this.DoctorSpecializationLabel.Size = new System.Drawing.Size(105, 20);
            this.DoctorSpecializationLabel.TabIndex = 9;
            this.DoctorSpecializationLabel.Text = "Specialization:";
            // 
            // DoctorSpecializationField
            // 
            this.DoctorSpecializationField.BackColor = System.Drawing.Color.Ivory;
            this.DoctorSpecializationField.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorSpecializationField.Location = new System.Drawing.Point(167, 229);
            this.DoctorSpecializationField.Name = "DoctorSpecializationField";
            this.DoctorSpecializationField.Size = new System.Drawing.Size(154, 27);
            this.DoctorSpecializationField.TabIndex = 13;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.DoctorSpecializationField);
            this.Controls.Add(this.DoctorSpecializationLabel);
            this.Controls.Add(this.DoctorNameField);
            this.Controls.Add(this.DoctorNameLabel);
            this.Controls.Add(this.DoctorIcon);
            this.Controls.Add(this.DoctorInformationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DoctorForm";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.DoctorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DoctorNameField;
        private System.Windows.Forms.Label DoctorNameLabel;
        private System.Windows.Forms.PictureBox DoctorIcon;
        private System.Windows.Forms.Label DoctorInformationLabel;
        private System.Windows.Forms.Label DoctorSpecializationLabel;
        private System.Windows.Forms.TextBox DoctorSpecializationField;
    }
}