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
    public partial class FrmUpdateInformations : Form
    {
        public FrmUpdateInformations()
        {
            InitializeComponent();
        }
        public string TC;
        SqlConnect myConnect = new SqlConnect();
        private void FrmUpdateInformations_Load(object sender, EventArgs e)
        {
            mskTC.Text = TC;
            SqlCommand cmd = new SqlCommand("select * from Tbl_Hastalar where HastaTC = @a1", myConnect.myConnection());
            cmd.Parameters.AddWithValue("@a1",mskTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtsurname.Text = dr[2].ToString();
                mskPhone.Text = dr[4].ToString();
                txtPassword.Text = dr[5].ToString();
                cmbGender.Text = dr[6].ToString();
            }
            myConnect.myConnection().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Hastalar set HastaAd =@p1, HastaSoyad =@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 where HastaTC=@p6",myConnect.myConnection());
            cmd.Parameters.AddWithValue("@p1",txtName.Text);
            cmd.Parameters.AddWithValue("@p2",txtsurname.Text);
            cmd.Parameters.AddWithValue("@p3",mskPhone.Text);
            cmd.Parameters.AddWithValue("@p4",txtPassword.Text);
            cmd.Parameters.AddWithValue("@p5",cmbGender.Text);
            cmd.Parameters.AddWithValue("@p6",mskTC.Text);
            cmd.ExecuteNonQuery(); //insert,update,delete only
            myConnect.myConnection().Close();
            MessageBox.Show("Bilgileriniz güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
