using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Oefening1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            connectionString.Text = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }
    }
}