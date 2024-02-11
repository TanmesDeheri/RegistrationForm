using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoUsermanagement
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void OnLoggingIn(object sender, EventArgs e)
        {
            string username = txtEmail.Text.Trim();

            Session["Username"] = username;

            Response.Redirect("~/Dashboard.aspx?username=" + Server.UrlEncode(username));
        }
    }
}