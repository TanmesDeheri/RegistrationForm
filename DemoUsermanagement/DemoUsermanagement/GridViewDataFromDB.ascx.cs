 using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoUsermanagement
{
    public partial class GridViewDataFromDB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindGridViewWithData();
            }
        }
        protected void BindGridViewWithData()
        {
            DataTable dt = GetUserData();
            GridViewData.DataSource = dt;
            GridViewData.DataBind();
        }
        protected DataTable GetUserData()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ConnectionString))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select BusinessEntityID,FirstName,MiddleName,LastName FROM Person.Person", con);
                    adapter.Fill(dt);
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                //error message
            }
            // Example: Retrieve data from a database (replace this with your actual data retrieval logic)
            // Populate DataTable with data
            // Example: dt = YourDataAccessLayer.GetData();
            // For demonstration purposes, let's create a sample DataTable with dummy data
            return dt;
        }
        protected void GridViewPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewData.PageIndex = e.NewPageIndex;
            BindGridViewWithData();
        }
    }
}