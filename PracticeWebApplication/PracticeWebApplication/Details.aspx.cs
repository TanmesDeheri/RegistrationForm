using PracticeWebApplication.Businesslayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeWebApplication
{
    public partial class Details : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack == true)
            {
                GetData();
            }
        }
        public void GetData()
        {

            DataSet result = BusinessLayer.disProduct();
            DataTable dt = result.Tables[0];
            DataList2.DataSource = result.Tables[0].DefaultView;
            DataList2.DataBind();
            DataTable td = dt;
            Session["dt"] = td;

        }
        protected void LinkButton_Click(Object sender, EventArgs e)
        {
            detashow();
        }
        public void detashow()
        {
        }
        protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "ViewDetails")
            {
                Response.Redirect("ViewDetails.aspx?id=" + e.CommandArgument.ToString());
            }
        }

    }
}