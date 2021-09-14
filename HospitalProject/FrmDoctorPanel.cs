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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }

        SqlConnect mySql = new SqlConnect();
        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Doktorlar", mySql.myConnection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //get branches to combobox
            SqlCommand cmd2 = new SqlCommand("select BransAd from Tbl_Branslar", mySql.myConnection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0].ToString());
            }
            mySql.myConnection().Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd, DoktorSoyad, DoktorBrans, DoktorTC, DoktorSifre) values (@a1, @a2, @a3, @a4, @a5)", mySql.myConnection());
            cmd.Parameters.AddWithValue("@a1", txtName.Text);
            cmd.Parameters.AddWithValue("@a2",txtSurname.Text);
            cmd.Parameters.AddWithValue("@a3",cmbBranch.Text);
            cmd.Parameters.AddWithValue("@a4",mskTC.Text);
            cmd.Parameters.AddWithValue("@a5",txtPassword.Text);
            cmd.ExecuteNonQuery();
            mySql.myConnection().Close();
            MessageBox.Show("Doktor eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            txtName.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            cmbBranch.Text = dataGridView1.Rows[choosen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[choosen].Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[choosen].Cells[5].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Tbl_Doktorlar where DoktorTC = @a1", mySql.myConnection());
            cmd.Parameters.AddWithValue("@a1", mskTC.Text);
            cmd.ExecuteNonQuery();
            mySql.myConnection().Close();
            MessageBox.Show("Kayıt silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@d1, DoktorSoyad=@d2, DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4", mySql.myConnection());
            cmd.Parameters.AddWithValue("@d1", txtName.Text);
            cmd.Parameters.AddWithValue("@d2", txtSurname.Text);
            cmd.Parameters.AddWithValue("@d3", cmbBranch.Text);
            cmd.Parameters.AddWithValue("@d4", mskTC.Text);
            cmd.Parameters.AddWithValue("@d5", txtPassword.Text);
            cmd.ExecuteNonQuery();
            mySql.myConnection().Close();
            MessageBox.Show("Bilgiler güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
