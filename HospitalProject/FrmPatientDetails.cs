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
    public partial class FrmPatientDetails : Form
    {
        public FrmPatientDetails()
        {
            InitializeComponent();
        }
        public string tc;
        SqlConnect myConnect = new SqlConnect();
        private void FrmPatientDetails_Load(object sender, EventArgs e)
        {
            //get Name Surname 
            lblTC.Text = tc;
            SqlCommand cmd = new SqlCommand("select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC = @a1", myConnect.myConnection());
            cmd.Parameters.AddWithValue("@a1",lblTC.Text);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lblNameSurname.Text = rd[0].ToString() +" "+rd[1].ToString();
            }
            myConnect.myConnection().Close();


            //last appointments
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdp = new SqlDataAdapter("select * from Tbl_Appointments where PatientTC = "+tc, myConnect.myConnection());
            dataAdp.Fill(dt); //dataadapterin içini tablodan gelen değerle doldur
            dtgPastAppointment.DataSource= dt; //datagridin veri kaynağı , td den gelen tablo
            
            //get branches
            SqlCommand cmd2 = new SqlCommand("select BransAd from Tbl_Branslar", myConnect.myConnection());
            SqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                cmbBranch.Items.Add(rd2[0]);
            }
            myConnect.myConnection().Close();
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            SqlCommand cmd = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans = @a1",myConnect.myConnection());
            cmd.Parameters.AddWithValue("@a1",cmbBranch.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbDoctor.Items.Add(dr[0]+" "+dr[1]);
            }
            myConnect.myConnection().Close();
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dtA = new SqlDataAdapter("select * from Tbl_Appointments where AppointmentBranch = '" +cmbBranch.Text+ "' and AppointmentDoctor = '" + cmbDoctor.Text + "' and AppointmentState = 0", myConnect.myConnection());
            dtA.Fill(dt);
            dtgAvailableAppointment.DataSource = dt;
        }

        private void lnkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUpdateInformations frmUpdate = new FrmUpdateInformations();
            frmUpdate.TC = lblTC.Text;
            frmUpdate.Show();
            //this.Hide();
        }

        private void dtgAvailableAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosed = dtgAvailableAppointment.SelectedCells[0].RowIndex;
            txtID.Text = dtgAvailableAppointment.Rows[chosed].Cells[0].Value.ToString();
        }

        private void btnMakeAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Appointments set AppointmentState = 1 , PatientTC = @p1, PatientComplaint = @p2 where AppointmentId=@p3",myConnect.myConnection());
            cmd.Parameters.AddWithValue("@p1", lblTC.Text);
            cmd.Parameters.AddWithValue("@p2",rchTxtComplaint.Text);
            cmd.Parameters.AddWithValue("@p3",txtID.Text);
            cmd.ExecuteNonQuery();
            myConnect.myConnection().Close();
            MessageBox.Show("Randevu alındı.", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
