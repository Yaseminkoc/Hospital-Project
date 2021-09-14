using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject
{
    public partial class FrmOptions : Form
    {
        public FrmOptions()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            FrmPatientLogin patientLogin = new FrmPatientLogin();
            patientLogin.Show();
            this.Hide();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            FrmDoctorSignIn doctorLogin = new FrmDoctorSignIn();
            doctorLogin.Show();
            this.Hide();
        }

        private void btnSecretary_Click(object sender, EventArgs e)
        {
            FrmSecretaryLogin secretaryLogin = new FrmSecretaryLogin();
            secretaryLogin.Show();
            this.Hide();
        }
    }
}
