using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
namespace oefening1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelConnString.Text = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }
    }
}