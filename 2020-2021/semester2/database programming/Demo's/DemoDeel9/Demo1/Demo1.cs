using System;
using System.Collections.Generic;

// Eerst reference leggen naar deze assembly in references
// Daarna opnemen in de using directives
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Demo1 : Form
    {
        #region Constructors

        public Demo1()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void Demo1_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void comboBoxConnectionStrings_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = comboBoxConnectionStrings.Text;

            textBoxConnectionString.Text = ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }

        #endregion

        #region Private methods

        private void FillCombo()
        {
            comboBoxConnectionStrings.DisplayMember = "Name";
            comboBoxConnectionStrings.ValueMember = "connectionString";

            foreach (ConnectionStringSettings s in ConfigurationManager.ConnectionStrings)
            {
                comboBoxConnectionStrings.Items.Add(s);
            }
        }

        #endregion
    }
}
