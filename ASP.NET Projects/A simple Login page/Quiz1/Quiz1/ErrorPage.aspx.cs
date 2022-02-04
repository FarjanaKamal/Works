using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz1
{
    public partial class ErrorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TryLoginBtn_Click(object sender, EventArgs e)
        {
            // Log-out button redirecting to Login page
            Response.Redirect("~/Login Page.aspx");
        }
    }
}