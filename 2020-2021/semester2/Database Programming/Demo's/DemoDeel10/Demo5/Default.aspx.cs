using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo4
{
    public partial class _Default : Page
    {
        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        #endregion

        #region Private methods

        private void ShowData()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand selectCommand = new SqlCommand();

            selectCommand.CommandText = "SELECT TOP 20 * FROM Person.Person;SELECT TOP 20 * FROM Production.Product";
            selectCommand.CommandType = CommandType.Text;

            adapter.SelectCommand = selectCommand;

            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                selectCommand.Connection = cnn;

                // cnn.Open();
                adapter.Fill(ds);

                this.GridView1.DataSource = ds.Tables[0];
                this.GridView1.DataBind();
            }
        }

        #endregion
    }
}