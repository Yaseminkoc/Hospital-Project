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
    public partial class FrmDoctorDetails : Form
    {
        public FrmDoctorDetails()
        {
            InitializeComponent();
        }
        public string tc;
        SqlConnect mySql = new SqlConnect();
        private void FrmDoctorDetails_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;
            //get name surname
            SqlCommand cmd = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTC = @a1", mySql.myConnection());
            cmd.Parameters.AddWithValue("@a1", lblTC.Text);
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                lblNameSurname.Text = dr1[0]+" "+dr1[1];
            }
            mySql.myConnection().Close();

            //appointments

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Appointments where AppointmentDoctor='"+lblNameSurname.Text+"'", mySql.myConnection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmDoctorInformationUpdate updateDoctor = new FrmDoctorInformationUpdate();
            updateDoctor.tc = lblTC.Text;
            updateDoctor.Show();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            FrmAnnouncements annFrm = new FrmAnnouncements();
            annFrm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosed = dataGridView1.SelectedCells[0].RowIndex;
            rchComplaint.Text = dataGridView1.Rows[chosed].Cells[7].Value.ToString();
        }
    }
}
