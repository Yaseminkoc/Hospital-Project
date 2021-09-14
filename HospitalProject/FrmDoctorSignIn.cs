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
    public partial class FrmDoctorSignIn : Form
    {
        public FrmDoctorSignIn()
        {
            InitializeComponent();
        }

        SqlConnect myConnect = new SqlConnect();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Doktorlar where DoktorTC=@a1 and DoktorSifre=@a2",myConnect.myConnection());
            cmd.Parameters.AddWithValue("@a1",mskTC.Text);
            cmd.Parameters.AddWithValue("@a2",txtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmDoctorDetails doctor = new FrmDoctorDetails();
                doctor.tc = mskTC.Text;
                doctor.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC ya da şifre yanlış, lütfen tekrar deneyiniz.");
            }
            myConnect.myConnection().Close();
        }
    }
}
