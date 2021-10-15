using Demo5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo5
{
    public partial class Demo5 : Form
    {
        #region Private members

        private List<DbLogEntry> _dbLogEntries;

        #endregion

        #region Constructors

        public Demo5()
        {
            InitializeComponent();
            _dbLogEntries = new List<DbLogEntry>();
        }

        #endregion

        #region Events

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadDatabaseLog();
        }

        private void Demo5_Load(object sender, EventArgs e)
        {
            LoadDatabaseLog();
        }

        #endregion

        #region Private methods

        private void LoadDatabaseLog()
        {
            _dbLogEntries = new List<DbLogEntry>();
            DbLogEntry dbLogEntry;
            string connString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
            string query = @"SELECT
                                  *
                              FROM 
                                [dbo].[AdventureWorks2019]";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text; // => Default setting
            cmd.CommandText = query;

            using (SqlConnection cnn = new SqlConnection(connString))
            {
                cmd.Connection = cnn;

                try
                {
                    cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        { 
                            dbLogEntry = new DbLogEntry()
                            {
                                DatabaseLogId = Convert.ToInt32(reader[0]),
                                PostTime = Convert.ToDateTime(reader[1]),
                                DatabaseUser = reader[2].ToString(),
                                Event = reader[3].ToString(),
                                Schema = reader[4].ToString(),
                                Object = reader[5].ToString(),
                                TSQL = reader[6].ToString(),
                            };

                            _dbLogEntries.Add(dbLogEntry);
                        }
                    }
                }
                catch(SqlException e)
                {
                    MessageBox.Show($"Er is een fout opgetreden bij het uitvoeren van de query {Environment.NewLine}{e.Message}");
                }
            }

            dataGridViewDbLogEntries.DataSource = _dbLogEntries;
        }

        #endregion
    }
}
