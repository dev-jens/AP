using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void GetAdressTypes()
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

        using(SqlConnection conn = new SqlConnection("context connection=true"))
        {
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            SqlContext.Pipe.Send(rdr);
            SqlContext.Pipe.Send(System.DateTime.Today.ToString());
            rdr.Close();
        }
    }
}
