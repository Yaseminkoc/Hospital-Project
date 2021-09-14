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
    public partial class FrmDoctorInformationUpdate : Form
    {
        public FrmDoctorInformationUpdate()
        {
            InitializeComponent();
        }

        public string tc;
        SqlConnect mySql = new SqlConnect();
        private void FrmDoctorInformationUpdate_Load(object sender, EventArgs e)
        {
            mskTC.Text = tc;

            SqlCommand cmd = new SqlCommand("select * from Tbl_Doktorlar where DoktorTC=@p1",mySql.myConnection());
            cmd.Parameters.AddWithValue("@p1",mskTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtsurname.Text = dr[2].ToString();
                cmbBranch.Text = dr[3].ToString();
                txtPassword.Text = dr[5].ToString();
            }
            mySql.myConnection().Close();

            //get branches o cmbbx
            SqlCommand cmd2 = new SqlCommand("select BransAd from Tbl_Branslar",mySql.myConnection());
            SqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                cmbBranch.Items.Add(rd2[0]);
            }
            mySql.myConnection().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@a1, DoktorSoyad=@a2, DoktorBrans=@a3, DoktorSifre=@a4 where DoktorTc=@a5",mySql.myConnection());
            cmd.Parameters.AddWithValue("@a1",txtName.Text);
            cmd.Parameters.AddWithValue("@a2",txtsurname.Text);
            cmd.Parameters.AddWithValue("@a3",cmbBranch.Text);
            cmd.Parameters.AddWithValue("@a4",txtPassword.Text);
            cmd.Parameters.AddWithValue("@a5",mskTC.Text);
            cmd.ExecuteNonQuery();
            mySql.myConnection().Close();
            MessageBox.Show("Bilgiler güncellendi.");

        }
    }
}
