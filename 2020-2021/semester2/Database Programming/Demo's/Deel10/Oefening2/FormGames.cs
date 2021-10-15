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

namespace Oefening2
{
    public partial class FormGames : System.Windows.Forms.Form
    {
        #region Private members

        private DataSet _games;

        #endregion

        #region Constructors

        public FormGames()
        {
            InitializeComponent();
        }

        #endregion

         #region Events
        private void FormGames_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                InitializeDataSet();
                InitializeTeams();
                InitializeDataGridViewSchedule();
                InitializeComboBoxHomeTeam();
                InitializeComboBoxVisitingTeam();
            }
        }

        private void buttonAddGame_Click(object sender, EventArgs e)
        {
            AddGame();
        }

        private void buttonDeleteGame_Click(object sender, EventArgs e)
        {
            DeleteGame();
        }

        private void buttonCountNewGames_Click(object sender, EventArgs e)
        {
            CountNewGames();
        }

        #endregion

        #region Private methods

        private void AddGame()
        {
            // rij toevoegen
            DataRow dr = _games.Tables["tblGames"].NewRow();
            dr["ID"] = Convert.ToInt32(textBoxGameNumber.Text);
            dr["GameDate"] = Convert.ToDateTime(dateTimePickerGameDate.Value);
            dr["HomeTeam"] = Convert.ToInt32(comboBoxHomeTeam.Text);
            dr["VisitingTeam"] = Convert.ToInt32(comboBoxVisitingTeam.Text);
            if (!string.IsNullOrEmpty(textBoxScoreHomeTeam.Text))
            {
                dr["HomeTeamScore"] = Convert.ToInt32(textBoxScoreHomeTeam.Text);
            }
            if (!string.IsNullOrEmpty(textBoxScoreVisitingTeam.Text))
            {
                dr["VisitingTeamScore"] = Convert.ToInt32(textBoxScoreVisitingTeam.Text);
            } 
        }

        private void DeleteGame()
        {
            foreach (DataGridViewRow row in dataGridViewSchedule.SelectedRows)
            {
                dataGridViewSchedule.Rows.RemoveAt(row.Index); 
            }
        }

        private void CountNewGames()
        {
            int counter = 0;
            foreach (DataRow dr in _games.Tables["tblGames"].Rows)
            {
                if (dr.RowState == DataRowState.Added)
                {
                    counter++;
                }
            }
            MessageBox.Show($"{counter} new games were added");
        }

        private void SaveGames()
        {
            string selectQuery = "DELETE FROM [dbo].[tblGames] WHERE [ID] = @prm_ID)";
            string insertQuery = "INSERT INTO [dbo].[tblGames] VALUES (@prm_ID, @prm_GameDate, @prm_HomeTeam, @prm_VisitingTeam, @prm_HomeTeamScore, @prm_VisitingTeamScore)";
            string updateQuery = @"
                                    UPDATE 
                                        [dbo].[tblGames] 
                                    SET 
                                        [GameDate] = @prm_GameDate, 
                                        [HomeTeam] = @prm_HomeTeam, 
                                        [VisitingTeam] = @prm_VisitingTeam,
                                        [HomeTeamScore] = @prm_HomeTeamScore, 
                                        [VisitingTeamScore] = @prm_VisitingTeamScore 
                                    WHERE   
                                        [ID] = @prm_ID";

            SqlCommand deleteCommand = new SqlCommand(selectQuery);
            deleteCommand.Parameters.Add(new SqlParameter("@prm_ID", SqlDbType.Int));
            deleteCommand.Parameters["@prm_ID"].SourceColumn = "ID";

            SqlCommand insertCommand = new SqlCommand(insertQuery);
            insertCommand.Parameters.Add(new SqlParameter("@prm_ID", SqlDbType.Int));
            insertCommand.Parameters["@prm_ID"].SourceColumn = "ID";
            insertCommand.Parameters.Add(new SqlParameter("@prm_GameDate", SqlDbType.DateTime));
            insertCommand.Parameters["@prm_GameDate"].SourceColumn = "GameDate";
            insertCommand.Parameters.Add(new SqlParameter("@prm_HomeTeam", SqlDbType.Int));
            insertCommand.Parameters["@prm_HomeTeam"].SourceColumn = "HomeTeam";
            insertCommand.Parameters.Add(new SqlParameter("@prm_VisitingTeam", SqlDbType.Int));
            insertCommand.Parameters["@prm_VisitingTeam"].SourceColumn = "VisitingTeam";
            insertCommand.Parameters.Add(new SqlParameter("@prm_HomeTeamScore", SqlDbType.Int));
            insertCommand.Parameters["@prm_HomeTeamScore"].SourceColumn = "HomeTeamScore";
            insertCommand.Parameters.Add(new SqlParameter("@prm_VisitingTeamScore", SqlDbType.Int));
            insertCommand.Parameters["@prm_VisitingTeamScore"].SourceColumn = "VisitingTeamScore";

            SqlCommand updateCommand = new SqlCommand(updateQuery);
            updateCommand.Parameters.Add(new SqlParameter("@prm_ID", SqlDbType.Int));
            updateCommand.Parameters["@prm_ID"].SourceColumn = "ID";
            updateCommand.Parameters.Add(new SqlParameter("@prm_GameDate", SqlDbType.DateTime));
            updateCommand.Parameters["@prm_GameDate"].SourceColumn = "GameDate";
            updateCommand.Parameters.Add(new SqlParameter("@prm_HomeTeam", SqlDbType.Int));
            updateCommand.Parameters["@prm_HomeTeam"].SourceColumn = "HomeTeam";
            updateCommand.Parameters.Add(new SqlParameter("@prm_VisitingTeam", SqlDbType.Int));
            updateCommand.Parameters["@prm_VisitingTeam"].SourceColumn = "VisitingTeam";
            updateCommand.Parameters.Add(new SqlParameter("@prm_HomeTeamScore", SqlDbType.Int));
            updateCommand.Parameters["@prm_HomeTeamScore"].SourceColumn = "HomeTeamScore";
            updateCommand.Parameters.Add(new SqlParameter("@prm_VisitingTeamScore", SqlDbType.Int));
            updateCommand.Parameters["@prm_VisitingTeamScore"].SourceColumn = "VisitingTeamScore";

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.DeleteCommand = deleteCommand;
            dataAdapter.InsertCommand = insertCommand;
            dataAdapter.UpdateCommand = updateCommand;

            if (_games.Tables["tblGames"].GetChanges() != null)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDeel10"].ConnectionString))
                {
                    deleteCommand.Connection = conn;
                    insertCommand.Connection = conn;
                    updateCommand.Connection = conn;
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        dataAdapter.DeleteCommand.Transaction = transaction;
                        dataAdapter.InsertCommand.Transaction = transaction;
                        dataAdapter.UpdateCommand.Transaction = transaction;

                        dataAdapter.Update(_games.Tables["tblGames"]);
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


        private void LoadTeams()
        {
            string query = "SELECT * FROM [dbo].[tblTeams] ORDER BY [NAME] ASC";
            SqlCommand selectCommand = new SqlCommand(query);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
            dataAdapter.SelectCommand = selectCommand;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDeel10"].ConnectionString))
            {
                selectCommand.Connection = conn;

                try
                {
                    conn.Open();
                    dataAdapter.Fill(_games.Tables["tblTeams"]);
                }
                catch (SqlException sqlEx)
                {
                    // Do logging here
                    throw;
                }
            }
        }

        private void LoadGames()
        {
            string query = "SELECT * FROM [dbo].[tblGames] ORDER BY [GameDate] DESC";
            SqlCommand selectCommand = new SqlCommand(query);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionDeel10"].ConnectionString))
            {
                selectCommand.Connection = conn;

                try
                {
                    conn.Open();
                    _games.Tables["tblGames"].Clear();
                    dataAdapter.Fill(_games.Tables["tblGames"]);
                }
                catch (SqlException sqlEx)
                {
                    // Do logging here
                    throw;
                }
            }
        }

        /// <summary>
        /// Initializes a List object with all NHL teams
        /// </summary>
        private void InitializeTeams()
        {
            _games.Tables["tblTeams"].Rows.Add(1, "Anaheim Ducks");
            _games.Tables["tblTeams"].Rows.Add(2, "Boston Bruins");
            _games.Tables["tblTeams"].Rows.Add(3, "Buffalo Sabres");
            _games.Tables["tblTeams"].Rows.Add(4, "Calgary Flames");
            _games.Tables["tblTeams"].Rows.Add(5, "Carolina Hurricanes");
            _games.Tables["tblTeams"].Rows.Add(6, "Chicago Black Hawks");
            _games.Tables["tblTeams"].Rows.Add(7, "Colorado Avalanche");
            _games.Tables["tblTeams"].Rows.Add(8, "Columbus Blue Jackets");
            _games.Tables["tblTeams"].Rows.Add(9, "Dallas Stars");
            _games.Tables["tblTeams"].Rows.Add(10, "Detroit Red Wings");
            _games.Tables["tblTeams"].Rows.Add(11, "Edmonton Oilers");
            _games.Tables["tblTeams"].Rows.Add(12, "Florida Panthers");
            _games.Tables["tblTeams"].Rows.Add(13, "Las Vegas Knights");
            _games.Tables["tblTeams"].Rows.Add(14, "Los Angeles Kingq");
            _games.Tables["tblTeams"].Rows.Add(15, "Minnesota Wild");
            _games.Tables["tblTeams"].Rows.Add(16, "Montreal Candadiens");
            _games.Tables["tblTeams"].Rows.Add(17, "Nashville Predators");
            _games.Tables["tblTeams"].Rows.Add(18, "New Jersey Devils");
            _games.Tables["tblTeams"].Rows.Add(19, "New York Islanders");
            _games.Tables["tblTeams"].Rows.Add(20, "New York Rangers");
            _games.Tables["tblTeams"].Rows.Add(21, "Ottawa Senators");
            _games.Tables["tblTeams"].Rows.Add(22, "Philadelphia Flyers");
            _games.Tables["tblTeams"].Rows.Add(23, "Phoenix Coyotes");
            _games.Tables["tblTeams"].Rows.Add(24, "Pittsburgh Penguins");
            _games.Tables["tblTeams"].Rows.Add(25, "Saint Louis Blues");
            _games.Tables["tblTeams"].Rows.Add(26, "San Jose Sharks");
            _games.Tables["tblTeams"].Rows.Add(27, "Toronto Maple Leafs");
            _games.Tables["tblTeams"].Rows.Add(28, "Tampa Bay Lightning");
            _games.Tables["tblTeams"].Rows.Add(29, "Vancouver Canucks");
            _games.Tables["tblTeams"].Rows.Add(30, "Washington Capitals");
            _games.Tables["tblTeams"].Rows.Add(31, "Winnipeg Jets");

            // Add logic to change the rowstate of these new added rows to unchanged
            _games.Tables["tblTeams"].AcceptChanges();
        }

        /// <summary>
        /// Initializes a new DataSet
        /// </summary>
        private void InitializeDataSet()
        {
            _games = new DataSet();

            _games.Tables.Add(new DataTable("tblTeams"));
            _games.Tables[0].Columns.Add(new DataColumn("ID", typeof(System.Int32)));
            _games.Tables[0].Columns.Add(new DataColumn("Name", typeof(System.String)));

            _games.Tables.Add(new DataTable("tblGames"));
            _games.Tables[1].Columns.Add(new DataColumn("ID", typeof(System.Int32)));
            _games.Tables[1].Columns.Add(new DataColumn("GameDate", typeof(System.DateTime)));
            _games.Tables[1].Columns.Add(new DataColumn("HomeTeam", typeof(System.Int32)));
            _games.Tables[1].Columns.Add(new DataColumn("VisitingTeam", typeof(System.Int32)));
            _games.Tables[1].Columns.Add(new DataColumn("HomeTeamScore", typeof(System.Int32)));
            _games.Tables[1].Columns.Add(new DataColumn("VisitingTeamScore", typeof(System.Int32)));

            // primarykey
            //teams
            _games.Tables[0].PrimaryKey = new DataColumn[] { _games.Tables[0].Columns["ID"] };
            //games
            _games.Tables[1].PrimaryKey = new DataColumn[] { _games.Tables[1].Columns["ID"] };

            //relatie
            _games.Relations.Add(_games.Tables["tblTeams"].Columns["ID"], _games.Tables["tblGames"].Columns["HomeTeam"]);
            _games.Relations.Add(_games.Tables["tblTeams"].Columns["ID"], _games.Tables["tblGames"].Columns["VisitingTeam"]);




        }
        
        /// <summary>
        /// Initializes the ComboBox for selecting the home team
        /// </summary>
        private void InitializeComboBoxHomeTeam()
        {
            this.comboBoxHomeTeam.DataSource = _games.Tables["tblTeams"];
            this.comboBoxHomeTeam.DisplayMember = "Name";
            this.comboBoxHomeTeam.ValueMember = "ID";
        }

        /// <summary>
        /// Initializes the ComboBox for selecting the visiting team
        /// </summary>
        private void InitializeComboBoxVisitingTeam()
        {
            this.comboBoxVisitingTeam.DataSource = _games.Tables["tblTeams"];
            this.comboBoxVisitingTeam.DisplayMember = "Name";
            this.comboBoxVisitingTeam.ValueMember = "ID";
            this.comboBoxVisitingTeam.BindingContext = new BindingContext();
        }

        /// <summary>
        /// Initializes the datagridview that shows all games
        /// </summary>
        private void InitializeDataGridViewSchedule()
        {
            dataGridViewSchedule.AutoGenerateColumns = false;

            ((DataGridViewComboBoxColumn)(dataGridViewSchedule.Columns["HomeTeam"])).DataSource = _games.Tables["tblTeams"];
            ((DataGridViewComboBoxColumn)(dataGridViewSchedule.Columns["HomeTeam"])).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)(dataGridViewSchedule.Columns["HomeTeam"])).ValueMember = "ID";

            ((DataGridViewComboBoxColumn)(dataGridViewSchedule.Columns["VisitingTeam"])).DataSource = _games.Tables["tblTeams"];
            ((DataGridViewComboBoxColumn)(dataGridViewSchedule.Columns["VisitingTeam"])).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)(dataGridViewSchedule.Columns["VisitingTeam"])).ValueMember = "ID";

            dataGridViewSchedule.DataSource = _games.Tables["tblGames"];
        }


        #endregion

       
    }
}
