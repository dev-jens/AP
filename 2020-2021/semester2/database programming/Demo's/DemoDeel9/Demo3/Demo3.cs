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

namespace Demo3
{
    public partial class Demo3 : Form
    {
        #region Constructors

        public Demo3()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void buttonOpenConnection_Click(object sender, EventArgs e)
        {
            string connString = Classes.Cryptography.DecryptString(ConfigurationManager.ConnectionStrings["MyConnName"].ConnectionString);
            SqlConnection cnn = new SqlConnection(connString);

            try
            {
                cnn.Open();
                MessageBox.Show("Connection is open!");
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            textBoxEncrypted.Text = Classes.Cryptography.EncryptString(textBoxDecrypted.Text);
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            textBoxDecrypted.Text = Classes.Cryptography.DecryptString(textBoxEncrypted.Text);
        }

        #endregion

    }
}
