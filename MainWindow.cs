using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System_MDI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowHideToolstripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShowHideToolstripToolStripMenuItem.Checked)
            {
                ToolStrip.Visible = true;
            } else
            {
                ToolStrip.Visible= false;
            }
        }
        private void OpenPatientForm()
        {
            PatientForm patientForm = new PatientForm();
            patientForm.MdiParent = this;
            patientForm.Show();
        }
        private void OpenDoctorForm()
        {
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.MdiParent = this;
            doctorForm.Show();
        }
        private void OpenBillingForm()
        {
            BillingForm billingForm = new BillingForm();
            billingForm.MdiParent = this;
            billingForm.Show();
        }
        private void HandleForms(object sender, EventArgs e)
        {
            if (NewDoctorFormButton.Pressed || OpenDoctorFormToolStripMenuItem.Pressed || NewDoctorToolStripMenuItem.Pressed) 
            {
                OpenDoctorForm();
            }
            else if (NewPatientFormButton.Pressed || OpenPatientFormToolStripMenuItem.Pressed || NewPatientToolStripMenuItem.Pressed)
            {
                OpenPatientForm();
            }
            else
            {
                OpenBillingForm();
            }
        }   

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TileVertiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void CloseAllWindosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form subWindow in this.MdiChildren)
            {
                subWindow.Close();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
