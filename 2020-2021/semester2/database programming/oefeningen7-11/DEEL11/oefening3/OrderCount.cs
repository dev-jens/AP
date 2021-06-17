using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction(DataAccess = DataAccessKind.Read)]
    public static SqlInt32 OrderCount()
    {
        string query = @"Select COUNT(*) FROM [Sales].[SalesOrderHeader]";
        SqlCommand cmd = new SqlCommand(query);
        cmd.CommandType = CommandType.Text;
        

        using(SqlConnection conn = new SqlConnection("context connection=true"))
        {
            cmd.Connection = conn;
            conn.Open();
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return new SqlInt32(result);
        }
    }
}
