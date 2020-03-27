using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace winform大作业
{
    class DBHelper
    {
        public static string connectionString = "Data Source=.;Initial Catalog=myschool;Integrated Security=true";
        public static SqlConnection conn = new SqlConnection(connectionString);
    }
}
