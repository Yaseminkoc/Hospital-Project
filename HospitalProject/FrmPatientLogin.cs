using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HospitalProject
{
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }

        private void lnkSignUp_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientRegister register = new FrmPatientRegister();
            register.Show();
            //  this.Hide();
        }
        SqlConnect mySqlConnect = new SqlConnect();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Hastalar where HastaTC = @a1 and HastaSifre = @a2",mySqlConnect.myConnection());
            cmd.Parameters.AddWithValue("@a1",mskTC.Text);
            cmd.Parameters.AddWithValue("@a2",txtPassword.Text);
            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                FrmPatientDetails patientDetails = new FrmPatientDetails();
                patientDetails.tc = mskTC.Text;
                patientDetails.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC ya da şifre, lütfen tekrar deneyiniz.");
            }
            mySqlConnect.myConnection().Close();

        }
    }
}
