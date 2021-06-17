using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sql statements
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Oefening2
{
    class Persoon
    {
        public static int GetpersonRecords()
        {
            int result = int.MinValue;

            string query = "SELECT COUNT(*) FROM Person.Person";
            
            SqlCommand SelectQuery = new SqlCommand(query);
            SelectQuery.CommandType = CommandType.Text;

            string connString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SelectQuery.Connection = conn;
                conn.Open();
                result = Convert.ToInt32(SelectQuery.ExecuteScalar());

            }

            return result;
        }

        
    }
}
