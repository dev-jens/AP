using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefenign4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            lb_output.Items.Clear();
            int counter = 0;
            string Query = @"SELECT [FirstName], [LastName] FROM [Person].Person WHERE ((@prm_Naam IS NULL) OR (LastName LIKE @prm_Naam)) AND ((@prm_Voornaam IS NULL) OR (FIRSTNAME LIKE @prm_Voornaam))";


            SqlCommand cmd = new SqlCommand(Query);
            cmd.CommandType = CommandType.Text;

            // naam param
            SqlParameter Naam = new SqlParameter("@prm_Naam", SqlDbType.VarChar);
            cmd.Parameters.Add(Naam);
            if (tb_Naam.Text.Length == 0)     
                Naam.Value = DBNull.Value;
            else
                Naam.Value = "%" + tb_Naam.Text + "%";
        
            // voornaam param
            SqlParameter Voornaam = new SqlParameter("@prm_Voornaam", SqlDbType.VarChar);
            cmd.Parameters.Add(Voornaam);
            if (this.tb_Voornaam.Text.Length == 0)
            {
                Voornaam.Value = DBNull.Value;
            }
            else
            {
                Voornaam.Value = "%" + tb_Voornaam.Text + "%";
            }

            using (SqlConnection cnn =  new  SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                cmd.Connection = cnn;
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
              

               while (reader.Read())
                {
                    counter++;
                    lb_output.Items.Add($"{counter}. {reader["FirstName"]}, {reader["Lastname"]}");
               }
                
            }

        }    
    }
}
