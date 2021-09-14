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
    public partial class FrmBranch : Form
    {
        public FrmBranch()
        {
            InitializeComponent();
        }

        SqlConnect mySql = new SqlConnect();
        private void FrmBranch_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar", mySql.myConnection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            mySql.myConnection().Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Branslar(BransAd) values (@a1)",mySql.myConnection());
            cmd.Parameters.AddWithValue("@a1",txtBranchName.Text);
            cmd.ExecuteNonQuery();
            mySql.myConnection().Close();
            MessageBox.Show("Branş eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            txtBranchID.Text = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            txtBranchName.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Tbl_Branslar where BransId=@a1",mySql.myConnection());
            cmd.Parameters.AddWithValue("@a1",txtBranchID.Text);
            cmd.ExecuteNonQuery();
            mySql.myConnection().Close();
            MessageBox.Show("Branş silindi.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Branslar set BransAd=@a1 where BransId=@a2 ",mySql.myConnection());
            cmd.Parameters.AddWithValue("@a1",txtBranchName.Text);
            cmd.Parameters.AddWithValue("@a2",txtBranchID.Text);
            cmd.ExecuteNonQuery();
            mySql.myConnection().Close();
            MessageBox.Show("Branş bilgisi güncellendi.");
        }
    }
}
