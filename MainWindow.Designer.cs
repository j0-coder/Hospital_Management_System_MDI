namespace Hospital_Management_System_MDI
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewBillingfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileVertiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowHideToolstripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewPatientFormButton = new System.Windows.Forms.ToolStripButton();
            this.NewDoctorFormButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewBillingFormButton = new System.Windows.Forms.ToolStripButton();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenPatientFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenDoctorFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAllWindosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.WindowToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(875, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPatientToolStripMenuItem,
            this.NewDoctorToolStripMenuItem,
            this.NewBillingfToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // NewPatientToolStripMenuItem
            // 
            this.NewPatientToolStripMenuItem.Name = "NewPatientToolStripMenuItem";
            this.NewPatientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewPatientToolStripMenuItem.Text = "New Patient";
            this.NewPatientToolStripMenuItem.Click += new System.EventHandler(this.HandleForms);
            // 
            // NewDoctorToolStripMenuItem
            // 
            this.NewDoctorToolStripMenuItem.Name = "NewDoctorToolStripMenuItem";
            this.NewDoctorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewDoctorToolStripMenuItem.Text = "New Doctor";
            this.NewDoctorToolStripMenuItem.Click += new System.EventHandler(this.HandleForms);
            // 
            // NewBillingfToolStripMenuItem
            // 
            this.NewBillingfToolStripMenuItem.Name = "NewBillingfToolStripMenuItem";
            this.NewBillingfToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewBillingfToolStripMenuItem.Text = "New Billing";
            this.NewBillingfToolStripMenuItem.Click += new System.EventHandler(this.HandleForms);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // WindowToolStripMenuItem
            // 
            this.WindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CascadeToolStripMenuItem,
            this.TileHorizontalToolStripMenuItem,
            this.TileVertiToolStripMenuItem,
            this.ShowHideToolstripToolStripMenuItem});
            this.WindowToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
            this.WindowToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.WindowToolStripMenuItem.Text = "Window ";
            // 
            // CascadeToolStripMenuItem
            // 
            this.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem";
            this.CascadeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.CascadeToolStripMenuItem.Text = "Cascade";
            this.CascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // TileHorizontalToolStripMenuItem
            // 
            this.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem";
            this.TileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.TileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.TileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // TileVertiToolStripMenuItem
            // 
            this.TileVertiToolStripMenuItem.Name = "TileVertiToolStripMenuItem";
            this.TileVertiToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.TileVertiToolStripMenuItem.Text = "Tile Vertical";
            this.TileVertiToolStripMenuItem.Click += new System.EventHandler(this.TileVertiToolStripMenuItem_Click);
            // 
            // ShowHideToolstripToolStripMenuItem
            // 
            this.ShowHideToolstripToolStripMenuItem.CheckOnClick = true;
            this.ShowHideToolstripToolStripMenuItem.Name = "ShowHideToolstripToolStripMenuItem";
            this.ShowHideToolstripToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ShowHideToolstripToolStripMenuItem.Text = "Show / Hide Toolstrip";
            this.ShowHideToolstripToolStripMenuItem.Click += new System.EventHandler(this.ShowHideToolstripToolStripMenuItem_Click);
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPatientFormButton,
            this.NewDoctorFormButton,
            this.toolStripSeparator1,
            this.NewBillingFormButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(875, 25);
            this.ToolStrip.TabIndex = 2;
            this.ToolStrip.Text = "toolStrip1";
            this.ToolStrip.Visible = false;
            // 
            // NewPatientFormButton
            // 
            this.NewPatientFormButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPatientFormButton.Image = global::Hospital_Management_System_MDI.Properties.Resources.patient_profile_people_svgrepo_com;
            this.NewPatientFormButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewPatientFormButton.Name = "NewPatientFormButton";
            this.NewPatientFormButton.Size = new System.Drawing.Size(95, 22);
            this.NewPatientFormButton.Text = "Patient Form";
            this.NewPatientFormButton.Click += new System.EventHandler(this.HandleForms);
            // 
            // NewDoctorFormButton
            // 
            this.NewDoctorFormButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDoctorFormButton.Image = global::Hospital_Management_System_MDI.Properties.Resources.doctor_man_profile_svgrepo_com;
            this.NewDoctorFormButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewDoctorFormButton.Name = "NewDoctorFormButton";
            this.NewDoctorFormButton.Size = new System.Drawing.Size(95, 22);
            this.NewDoctorFormButton.Text = "Doctor Form";
            this.NewDoctorFormButton.Click += new System.EventHandler(this.HandleForms);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // NewBillingFormButton
            // 
            this.NewBillingFormButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBillingFormButton.Image = global::Hospital_Management_System_MDI.Properties.Resources.hospital_billing_payment_svgrepo_com;
            this.NewBillingFormButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewBillingFormButton.Name = "NewBillingFormButton";
            this.NewBillingFormButton.Size = new System.Drawing.Size(91, 22);
            this.NewBillingFormButton.Text = "Billing Form";
            this.NewBillingFormButton.Click += new System.EventHandler(this.HandleForms);
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenPatientFormToolStripMenuItem,
            this.OpenDoctorFormToolStripMenuItem,
            this.CloseAllWindosToolStripMenuItem});
            this.ContextMenuStrip1.Name = "contextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(192, 70);
            // 
            // OpenPatientFormToolStripMenuItem
            // 
            this.OpenPatientFormToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenPatientFormToolStripMenuItem.Name = "OpenPatientFormToolStripMenuItem";
            this.OpenPatientFormToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.OpenPatientFormToolStripMenuItem.Text = "Open Patient Form";
            this.OpenPatientFormToolStripMenuItem.Click += new System.EventHandler(this.HandleForms);
            // 
            // OpenDoctorFormToolStripMenuItem
            // 
            this.OpenDoctorFormToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenDoctorFormToolStripMenuItem.Name = "OpenDoctorFormToolStripMenuItem";
            this.OpenDoctorFormToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.OpenDoctorFormToolStripMenuItem.Text = "Open Doctor Form";
            // 
            // CloseAllWindosToolStripMenuItem
            // 
            this.CloseAllWindosToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAllWindosToolStripMenuItem.Name = "CloseAllWindosToolStripMenuItem";
            this.CloseAllWindosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.CloseAllWindosToolStripMenuItem.Text = "Close All Windows";
            this.CloseAllWindosToolStripMenuItem.Click += new System.EventHandler(this.CloseAllWindosToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 748);
            this.ContextMenuStrip = this.ContextMenuStrip1;
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewBillingfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TileVertiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowHideToolstripToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton NewPatientFormButton;
        private System.Windows.Forms.ToolStripButton NewDoctorFormButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton NewBillingFormButton;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenPatientFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenDoctorFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseAllWindosToolStripMenuItem;
    }
}

