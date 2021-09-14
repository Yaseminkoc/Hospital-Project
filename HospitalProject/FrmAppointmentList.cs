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
    public partial class FrmAppointmentList : Form
    {
        public FrmAppointmentList()
        {
            InitializeComponent();
        }
        SqlConnect mySql = new SqlConnect();
        private void FrmAppointmentList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Appointments", mySql.myConnection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        
    
    }
}
