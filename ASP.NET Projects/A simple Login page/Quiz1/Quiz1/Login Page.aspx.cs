using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            //Validating the user credentials
            if (Login1.UserName=="admin" && Login1.Password=="admin")
                e.Authenticated=true;
            else
            {
                e.Authenticated = false;

                //If the credentials not matching to given one then redirecting to an error page
                Response.Redirect("~/ErrorPage.aspx");
            }
               
        }
    }
}