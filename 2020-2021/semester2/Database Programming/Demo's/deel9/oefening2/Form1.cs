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

namespace oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getCount_Click(object sender, EventArgs e)
        {
            tbOutput.Text = Person.GetQuery().ToString();
        }


        class Person
        {

            public static int GetQuery()
            {
                int result = -1;
                string query = @"SELECT COUNT(*) FROM [Person].[Person]";

                SqlCommand cmd = new SqlCommand(query);
                cmd.CommandType = CommandType.Text;

                string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cmd.Connection = cnn;
                    cnn.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }

                return result;
            }

        }
        
    }
}
