using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlInt32 GetLastAddedProductID()
    {
        // Put your code here
        string query = @"SELECT TOP 1 ID  FROM [Production].[Product] RDER BY ID DESC";
        SqlCommand cmd = new SqlCommand(query);

        using (SqlConnection conn = new SqlConnection("context connection=true"))
        {
            cmd.Connection = conn;
            conn.Open();
            return new SqlInt32(Convert.ToInt32(cmd.ExecuteScalar()));
        }
    }
}
