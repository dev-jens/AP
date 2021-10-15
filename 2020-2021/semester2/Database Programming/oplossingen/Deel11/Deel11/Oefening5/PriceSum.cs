using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void PriceSum (out SqlDecimal totalValue)
    {
        using (SqlConnection connection = new SqlConnection("context connection=true"))
        {
            string query = @"
                            SELECT
                                SUM([ListPrice])
                            FROM
                                [Production].[Product]";

            totalValue = 0;
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            totalValue = new SqlDecimal(Convert.ToDecimal(command.ExecuteScalar()));
        }
    }
}
