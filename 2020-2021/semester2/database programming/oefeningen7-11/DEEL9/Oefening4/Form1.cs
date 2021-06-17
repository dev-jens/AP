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
//sql statements
using System.Configuration;
using System.Data.SqlClient;



namespace Oefening4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Filter_btn_Click(object sender, EventArgs e)
        {
            GetPerson();
        }

        private void GetPerson()
        {
            int counter = 0;

            string query = "SELECT FirstName, Lastname FROM Person.Person WHERE ((@prmFirstName IS NULL) or (FirstName LIKE @prmFirstName)) and ((@prm_lastname IS NULL) or (Lastname like @prm_lastname))";
            string query2 ="SELECT FirstName, LastName FROM Person.Person WHERE ((@prmFirstName IS NULL) OR (FirstName LIKE @prmFirstName)) AND ((@prmLastName IS NULL) OR (LastName LIKE @prmLastName))";
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = CommandType.Text;

            SqlParameter prmfirstname = new SqlParameter("@prmFirstName", SqlDbType.VarChar);
            SqlParameter prmlastname = new SqlParameter("@prm_lastname", SqlDbType.VarChar);

            if (inputVoornaam.Text.Length == 0)
                prmfirstname.Value = DBNull.Value;
            else
                prmfirstname.Value = "%" + inputVoornaam.Text + "%";

            if (InputNaam.Text.Length == 0)
                prmlastname.Value = DBNull.Value;
            else
                prmlastname.Value = "%" + InputNaam.Text + "%";

            cmd.Parameters.Add(prmfirstname);
            cmd.Parameters.Add(prmlastname);

            using(SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString))
            {
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    counter++;
                    outputBox.AppendText($"{counter}: {reader["Firstname"]}, {reader["Lastname"]} \t");
                }
            }


        }
    }
}
