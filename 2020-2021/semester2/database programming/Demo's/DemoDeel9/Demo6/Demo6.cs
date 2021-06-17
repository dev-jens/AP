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

namespace Demo6
{
    public partial class Demo6 : Form
    {
        #region Constructors

        public Demo6()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SavePlayer();
        }

        #endregion

        #region Private methods

        private void SavePlayer()
        {
            string connString = ConfigurationManager.ConnectionStrings["Tennis"].ConnectionString;

            SqlCommand cmdInsert = new SqlCommand();

            cmdInsert.CommandText = "spInsertSpeler";
            cmdInsert.CommandType = CommandType.StoredProcedure;

            SqlParameter prmSpelersNr = new SqlParameter("@prmSpelersNr", SqlDbType.Int);
            prmSpelersNr.Value = textBoxSpelersNr.Text;
            cmdInsert.Parameters.Add(prmSpelersNr);

            SqlParameter prmNaam = new SqlParameter("@prmNaam", SqlDbType.Char);
            prmNaam.Size = 15;
            prmNaam.Value = textBoxNaam.Text;
            cmdInsert.Parameters.Add(prmNaam);

            SqlParameter prmVoorletters = new SqlParameter("@prmVoorletters", SqlDbType.Char);
            prmVoorletters.Size = 3;
            prmVoorletters.Value = textBoxVoorletters.Text;
            cmdInsert.Parameters.Add(prmVoorletters);

            SqlParameter prmGebDatum = new SqlParameter("@prmGeb_Datum", SqlDbType.Date);

            if (String.IsNullOrEmpty(textBoxGeboorteDatum.Text))
            {
                prmGebDatum.Value = DBNull.Value;
            }
            else
            {
                prmGebDatum.Value = textBoxGeboorteDatum.Text;
            }

            cmdInsert.Parameters.Add(prmGebDatum);

            SqlParameter prmGeslacht = new SqlParameter("@prmGeslacht", SqlDbType.Char);
            prmGeslacht.Size = 1;
            prmGeslacht.Value = comboBoxGeslacht.Text;
            cmdInsert.Parameters.Add(prmGeslacht);

            SqlParameter prmJaartoe = new SqlParameter("@prmJaarToe", SqlDbType.SmallInt);
            prmJaartoe.Value = textBoxJaarToetreding.Text;
            cmdInsert.Parameters.Add(prmJaartoe);

            SqlParameter prmStraat = new SqlParameter("@prmStraat", SqlDbType.VarChar);
            prmStraat.Size = 30;
            prmStraat.Value = textBoxStraat.Text;
            cmdInsert.Parameters.Add(prmStraat);

            SqlParameter prmHuisNr = new SqlParameter("@prmHuisNr", SqlDbType.Char);
            prmHuisNr.Size = 4;

            if (String.IsNullOrEmpty(textBoxHuisNummer.Text))
            {
                prmHuisNr.Value = DBNull.Value;
            }
            else
            {
                prmHuisNr.Value = textBoxHuisNummer.Text;
            }

            cmdInsert.Parameters.Add(prmHuisNr);

            SqlParameter prmPostCode = new SqlParameter("@prmPostCode", SqlDbType.Char);
            prmPostCode.Size = 6;

            if (String.IsNullOrEmpty(textBoxPostcode.Text))
            {
                prmPostCode.Value = DBNull.Value;
            }
            else
            {
                prmPostCode.Value = textBoxPostcode.Text;
            }

            cmdInsert.Parameters.Add(prmPostCode);

            SqlParameter prmPlaats = new SqlParameter("@prmPlaats", SqlDbType.VarChar);
            prmPlaats.Size = 30;
            prmPlaats.Value = textBoxPlaats.Text;
            cmdInsert.Parameters.Add(prmPlaats);

            SqlParameter prmTelefoon = new SqlParameter("@prmTelefoon", SqlDbType.Char);
            prmTelefoon.Size = 13;

            if (String.IsNullOrEmpty(textBoxTelefoon.Text))
            {
                prmTelefoon.Value = DBNull.Value;
            }
            else
            {
                prmTelefoon.Value = textBoxTelefoon.Text;
            }

            cmdInsert.Parameters.Add(prmTelefoon);

            SqlParameter prmBondsNr = new SqlParameter("@prmBondsNr", SqlDbType.Char);
            prmBondsNr.Size = 4;

            if (String.IsNullOrEmpty(textBoxBondsNummer.Text))
            {
                prmBondsNr.Value = DBNull.Value;
            }
            else
            {
                prmBondsNr.Value = textBoxBondsNummer.Text;
            }

            cmdInsert.Parameters.Add(prmBondsNr);

            using (SqlConnection cnn = new SqlConnection(connString))
            {
                try
                {
                    cmdInsert.Connection = cnn;
                    cnn.Open();
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("Record insterted!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(string.Format("Error message : {0}\n\nStacktrace : {1}", ex.Message, ex.StackTrace));
                }
            }
        }

        #endregion
    }
}
