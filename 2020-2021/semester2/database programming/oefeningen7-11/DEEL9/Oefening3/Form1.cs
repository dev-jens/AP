using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sql statements
using System.Configuration;
using System.Data.SqlClient;


namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Record_btn_Click(object sender, EventArgs e)
        {
            getRecords();  
      
        }

        private void getRecords()
        {
            int counter = 0;
            //SqlDataReader reader;

            string SelectCommand = "SELECT TOP 100 * FROM Person.Person";
            SqlCommand cmd = new SqlCommand(SelectCommand);
            cmd.CommandType = CommandType.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    counter++;
                    LB_Records.Items.Add($"{counter}: {reader["Lastname"]}, {reader["Firstname"]}");
                }
            }

        }


    }
}
