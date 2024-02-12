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
            string userEmail = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            Session["Username"] = userEmail;
            Session["password"] = password;

            if (String.Equals(userEmail, "deheritanmessom@gmail.com") && String.Equals(password,"123!@#"))
            {
                Response.Redirect("~/Dashboard.aspx?userEmail=" + Server.UrlEncode(userEmail));
            }
            else
            {
                Response.Redirect("~/PageNotFound.aspx");
            }
        }
    }
}