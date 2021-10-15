using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void GetAddressTypes()
    {
        string query = @"
                        SELECT
                            [AddressTypeID],
                            [Name]
                        FROM
                            [Person].[AddressType]
                        ORDER BY
                            [AddressTypeID]";

        SqlCommand cmd = new SqlCommand(query);

        using (SqlConnection connection = new SqlConnection("context connection=true"))
        {
            cmd.Connection = connection;
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            SqlContext.Pipe.Send(reader);
            SqlContext.Pipe.Send(System.DateTime.Today.ToString());
            reader.Close();
        }
    }
}
