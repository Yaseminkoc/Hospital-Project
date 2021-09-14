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
    public partial class FrmSecretaryDetails : Form
    {
        public FrmSecretaryDetails()
        {
            InitializeComponent();
        }

        public string TC;
        SqlConnect mySql = new SqlConnect();
       
        private void FrmSecretaryDetails_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;

            //get name surname
            SqlCommand cmd = new SqlCommand("select SekreterAdSoyad from Tbl_Sekreterler where SekreterTC = @a1",mySql.myConnection());
            cmd.Parameters.AddWithValue("@a1",lblTC.Text);
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                lblNameSurname.Text = dr1[0].ToString();
            }
            mySql.myConnection().Close();

            //get branches to datagridview
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select BransAd from Tbl_Branslar", mySql.myConnection());
            da.Fill(dt);
            dtgBranchs.DataSource = dt;

            //get doctors to list
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select (DoktorAd + ' ' +DoktorSoyad) as 'Doktorlar', DoktorBrans  from Tbl_Doktorlar", mySql.myConnection());
            da1.Fill(dt1);
            dtgDoctors.DataSource = dt1;

            //get branches to combobox 
            SqlCommand cmd2 = new SqlCommand("select BransAd from Tbl_Branslar",mySql.myConnection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0].ToString());
            }
            mySql.myConnection().Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand getAppointment = new SqlCommand("insert into Tbl_Appointments (AppointmentDate,AppointmentTime,AppointmentBranch,AppointmentDoctor) values (@r1,@r2,@r3,@r4)", mySql.myConnection());
            getAppointment.Parameters.AddWithValue("@r1", mskDate.Text);
            getAppointment.Parameters.AddWithValue("@r2",mskTime.Text);
            getAppointment.Parameters.AddWithValue("@r3",cmbBranch.Text);
            getAppointment.Parameters.AddWithValue("@r4", cmbDoctor.Text);
            getAppointment.ExecuteNonQuery();
            mySql.myConnection().Close();
            MessageBox.Show("Randevu oluşturuldu.");
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            SqlCommand cmd = new SqlCommand("select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorBrans = @a1", mySql.myConnection());
            cmd.Parameters.AddWithValue("@a1",cmbBranch.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbDoctor.Items.Add(dr[0]+" "+dr[1]);
            }
            mySql.myConnection().Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@a1)", mySql.myConnection());
            cmd.Parameters.AddWithValue("@a1",rchAnnouncement.Text);
            cmd.ExecuteNonQuery();
            mySql.myConnection().Close();
            MessageBox.Show("Duyuru oluşturuldu.");
        }

        private void btnDoctorPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel doctorPanel = new FrmDoctorPanel();
            doctorPanel.Show();
        }

        private void btnBranchPanel_Click(object sender, EventArgs e)
        {
            FrmBranch branch = new FrmBranch();
            branch.Show();
        }

        private void btnAppointmentsList_Click(object sender, EventArgs e)
        {
            FrmAppointmentList frmList = new FrmAppointmentList();
            frmList.Show();
        }

     
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Tbl_Appointments where AppointmentId = @a1", mySql.myConnection());
            cmd.Parameters.AddWithValue("@a1", txtID.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Randevu silindi.");
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            FrmAnnouncements annountcements = new FrmAnnouncements();
            annountcements.Show();
        }
    }
}
