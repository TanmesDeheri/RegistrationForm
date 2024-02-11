using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeWebApplication
{
    public partial class PracticeGridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ConnectionString))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select BusinessEntityID,FirstName,MiddleName,LastName FROM Person.Person", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = String.Empty;
                ErrorMessage.Text = ex.Message;
            }
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                GridView1.PageIndex = e.NewPageIndex;
                BindGridView();
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = String.Empty;
                ErrorMessage.Text = ex.Message;
            }
        }

        private void BindGridView()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ConnectionString))
                {

                    con.Open();


                    SqlDataAdapter adapter = new SqlDataAdapter("Select BusinessEntityID, FirstName, MiddleName, LastName FROM Person.Person", con);
                    DataTable dt = new DataTable();


                    adapter.Fill(dt);


                    GridView1.DataSource = dt;


                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = String.Empty;
                ErrorMessage.Text = ex.Message;

            }
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {

        }
    }
}