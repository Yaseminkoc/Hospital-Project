using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HospitalProject
{
    class SqlConnect
    {
        public SqlConnection myConnection()
        {
            SqlConnection myConnectionUrl = new SqlConnection("Data Source=LAPTOP-LPHCITMN;Initial Catalog=HospitalProject;Integrated Security=True");
            myConnectionUrl.Open();
            return myConnectionUrl;
        }
    }
}
