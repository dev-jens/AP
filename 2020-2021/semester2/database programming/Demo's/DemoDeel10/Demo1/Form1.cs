using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void buttonGet_Click(object sender, EventArgs e)
        {
            ShowPersons();
        }    

        #endregion

        #region Private methods

        private void ShowPersons()
        {
            int teller = 0;

            SqlCommand commandSelect = new SqlCommand("SELECT TOP 100 * FROM Person.Person");
            commandSelect.CommandType = CommandType.Text;

            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["AdvWorks"].ConnectionString))
            {
                commandSelect.Connection = cnn;

                cnn.Open();
                SqlDataReader rdr = commandSelect.ExecuteReader();

                while (rdr.Read())
                {
                    teller++;
                    this.textBoxResult.AppendText(string.Format("{0}.\t{1} {2}\n", teller, rdr["FirstName"], rdr["LastName"]));

                    if (teller == 50)
                    {
                        // Closing connection while still reading will cause an exception
                        // This shows that the reader needs an active connection for reading from a database
                        cnn.Close();
                    }
                }
            }
        }

        #endregion
    }
}
