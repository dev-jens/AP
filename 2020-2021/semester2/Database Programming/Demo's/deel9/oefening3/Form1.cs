using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_loadRecords_Click(object sender, EventArgs e)
        {
            GetPersons();
        }

       
            public void GetPersons()
            {
                int index = 0;
                string query = @"Select TOP 100 * FROM [Person].[Person]";

                SqlCommand cmd = new SqlCommand(query);
                cmd.CommandType = CommandType.Text;

                string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                using(SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cmd.Connection = cnn;
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    index++;
                    listBox1.Items.Add($"{index},{reader["FirstName"]} {reader["LastName"]}");
                 

                }
              
            }

        }

       
    }
}
