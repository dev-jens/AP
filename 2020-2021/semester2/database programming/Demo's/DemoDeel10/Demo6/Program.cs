using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Tennis"].ConnectionString))
            {
                // Demo using a local transaction
                SqlCommand cmdInsertParent = new SqlCommand();
                SqlCommand cmdInsertChildren = new SqlCommand();

                cmdInsertParent.CommandText = "INSERT INTO SPELERS VALUES(200,'MyName', 'MN', '10/04/2014','M','2000','MyRoad','1','2000','Antwerpen','007','1')";
                cmdInsertParent.CommandType = CommandType.Text;
                cmdInsertParent.Connection = conn;

                // To test behaviour of rollback, use key of existing record for betalingsnr
                // To test behaviour of commit, use non-existing key for betalingsnr
                // cmdInsertChildren.CommandText = "INSERT INTO BOETES VALUES(1,200,'01/01/2010',200)";
                cmdInsertChildren.CommandText = "INSERT INTO BOETES VALUES(10,200,'01/01/2010',200)";
                cmdInsertChildren.CommandType = CommandType.Text;
                cmdInsertChildren.Connection = conn;

                conn.Open();
                // First start a transaction
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // Then assign the transaction to all commands that should be part of the transaction
                    cmdInsertParent.Transaction = trans;
                    cmdInsertChildren.Transaction = trans;
                    cmdInsertParent.ExecuteNonQuery();
                    cmdInsertChildren.ExecuteNonQuery();
                    // Commit the transaction
                    trans.Commit();
                }
                catch (Exception e)
                {
                    // In case of an exception, try to rollback the transaction
                    try
                    {
                        Console.WriteLine(e.Message);
                        trans.Rollback();
                    }
                    catch (Exception se)
                    {
                        // In case rollback fails (e.g. closed connection) cleanup should happen here
                        Console.WriteLine(se.Message);
                    }
                    
                }
                finally
                {
                    Console.ReadLine();
                }
            }
        }
    }
}
