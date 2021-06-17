using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction(DataAccess =DataAccessKind.Read)]
    public static SqlInt32 OrderCount()
    {
        string query = @"
                        SELECT
                            COUNT(*) AS [Order count]
                        FROM
                            [Sales].[SalesOrderHeader]";

        using (SqlConnection connection = new SqlConnection("context connection=true"))
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            return new SqlInt32(Convert.ToInt32(cmd.ExecuteScalar()));
        }
    }
}
