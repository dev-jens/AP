using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void PriceSum (out SqlDecimal price)
    {
        string query = @"
                            SELECT
                                SUM([ListPrice])
                            FROM
                                [Production].[Product]";
        SqlCommand cmd = new SqlCommand(query);

        using(SqlConnection conn = new SqlConnection("context connection=true"))
        {
            cmd.Connection = conn;
            conn.Open();
            price = new SqlDecimal(Convert.ToDecimal(cmd.ExecuteScalar()));
        }
    }
}
