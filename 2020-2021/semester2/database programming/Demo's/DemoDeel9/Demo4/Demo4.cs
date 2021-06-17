using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo4
{
    public partial class Demo4 : Form
    {
        #region Constructors

        public Demo4()
        {
            InitializeComponent();
        }

        #endregion

        #region Demo part 1

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // http://msdn.microsoft.com/en-us/library/8xx3tyca%28v=vs.110%29.aspx

            string connString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

            SqlConnection cnn = new SqlConnection(connString);

            MessageBox.Show(cnn.State.ToString());
            // Manueel connectie openen
            cnn.Open();
            MessageBox.Show(cnn.State.ToString());
            // Is ook manueel de connectie sluiten!!
            // Afhankelijk van connection pooling wordt de connectie al dan niet effectief gesloten
            cnn.Close();
            MessageBox.Show(cnn.State.ToString());
        }

        #endregion

        #region Demo part 2

        private void buttonOpenUsing_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;

            // Using statement werkt als een try/finally block.
            // Het zorgt er voor dat de resource die in het using statement gebruikt wordt netjes terug wordt vrijgegeven ongeacht wat er gebeurd.
            using (SqlConnection cnn = new SqlConnection(connString))
            {
                MessageBox.Show(cnn.State.ToString());
                // Using statement opent de connectie niet, maar sluit ze wel wanneer de code out of scope gaat
                cnn.Open();
                MessageBox.Show(cnn.State.ToString());
            }
        }

        #endregion

        #region Demo part 3

        private void buttonRestrictedMaxPoolSize_Click(object sender, EventArgs e)
        {
            checkBoxSqlConnection1.Checked = false;
            checkBoxSqlConnection2.Checked = false;
            string connString = ConfigurationManager.ConnectionStrings["myConnectionMax1"].ConnectionString;

            using (SqlConnection cnn1 = new SqlConnection(connString))
            {
                try
                {
                    cnn1.Open();
                    checkBoxSqlConnection1.Checked = true;
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Opening first connection failed!\n\n" + ex.Message);
                }

                using (SqlConnection cnn2 = new SqlConnection(connString))
                {
                    try
                    {
                        cnn2.Open();
                        checkBoxSqlConnection2.Checked = true;      
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show("Opening second connection failed!\n\n" + ex.Message);
                    }
                }
            }
        }

        #endregion

    }
}
