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
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();
        }
        SqlConnect mySql = new SqlConnect();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Sekreterler where SekreterTc = @p1 and SekreterSifre = @p2", mySql.myConnection());
            cmd.Parameters.AddWithValue("@p1", mskTC.Text);
            cmd.Parameters.AddWithValue("@p2",txtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) //sorgulama işlemi doğru bir şekilde gerçekleşti mi onu kontrol eder.
            {
                FrmSecretaryDetails frs = new FrmSecretaryDetails();
                frs.TC = mskTC.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı şifre ya da TC");
            }
            mySql.myConnection().Close();
        }

    }
}
