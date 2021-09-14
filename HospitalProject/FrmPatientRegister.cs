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
    public partial class FrmPatientRegister : Form
    {
        public FrmPatientRegister()
        {
            InitializeComponent();
        }

        SqlConnect mySqlConnect = new SqlConnect();

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Hastalar(HastaAd, HastaSoyad, HastaTC, HastaTelefon, HastaSifre, HastaCinsiyet) values (@a1, @a2, @a3, @a4 ,@a5, @a6)", mySqlConnect.myConnection());
            cmd.Parameters.AddWithValue("@a1",txtName.Text);
            cmd.Parameters.AddWithValue("@a2",txtsurname.Text);
            cmd.Parameters.AddWithValue("@a3", mskTC.Text);
            cmd.Parameters.AddWithValue("@a4", mskPhone.Text);
            cmd.Parameters.AddWithValue("@a5", txtPassword.Text);
            cmd.Parameters.AddWithValue("@a6", cmbGender.Text);
            cmd.ExecuteNonQuery();
            mySqlConnect.myConnection().Close();
            MessageBox.Show("Kaydınız gerçekleşmiştir. Şifreniz: "+txtPassword.Text,"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
