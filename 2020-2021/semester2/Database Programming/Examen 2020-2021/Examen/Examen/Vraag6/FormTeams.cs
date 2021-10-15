using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;

namespace Vraag6
{
    public partial class FormTeams : Form
    {
        public FormTeams()
        {
            InitializeComponent();
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTeamNumber.Text) || string.IsNullOrEmpty(textBoxDivision.Text) || string.IsNullOrEmpty(comboBoxPlayer.Text))
            {
                MessageBox.Show("er is een veld niet ingevuld");
            }
            else
            {
                AddTeam();
            }
          
        }

        private void AddTeam()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add("TEAMS");

            ds.Tables["TEAMS"].Columns.Add("TEAMNR", typeof(System.Int32));
            ds.Tables["TEAMS"].Columns["TEAMNR"].AllowDBNull = false;
            ds.Tables["TEAMS"].Columns.Add("SPELERNR", typeof(System.Int32));
            ds.Tables["TEAMS"].Columns["SPELERNR"].AllowDBNull = false;
            ds.Tables["TEAMS"].Columns.Add("DIVISIE", typeof(System.Char));
            ds.Tables["TEAMS"].Columns["DIVISIE"].MaxLength = 6;
            ds.Tables["TEAMS"].Columns["DIVISIE"].AllowDBNull = false;


            string query = @"INSERT INTO [dbo].[TEAMS] VALUES(@prm_teamnr, @prm_spelernr, @prm_devisie)";

            SqlCommand insertCommand = new SqlCommand(query);
            insertCommand.Parameters.Add(new SqlParameter("@prm_teamnr", SqlDbType.Int));
            insertCommand.Parameters["@prm_ID"].SourceColumn = "TEAMNR";
            insertCommand.Parameters.Add(new SqlParameter("@prm_spelernr", SqlDbType.Int));
            insertCommand.Parameters["@prm_GameDate"].SourceColumn = "SPELERNR";
            insertCommand.Parameters.Add(new SqlParameter("@prm_devisie", SqlDbType.Char));
            insertCommand.Parameters["@prm_HomeTeam"].SourceColumn = "Divisie";

            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString))
            {

                insertCommand.Connection = conn;
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {

                    dataAdapter.InsertCommand.Transaction = transaction;
                    dataAdapter.Update(ds.Tables["TEAMS"]);
                    transaction.Commit();
                }
                catch (SqlException sqlEx)
                {
                    transaction.Rollback();
                    // Do some logging here
                    throw;
                }

            }
        }
    }
}
