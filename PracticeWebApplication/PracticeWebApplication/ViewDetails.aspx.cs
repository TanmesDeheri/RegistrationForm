using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeWebApplication
{
    public partial class ViewDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();

        }
        public void GetData()
        {
            DataTable dt = (DataTable)Session["dt"];
            Image1.ImageUrl = dt.Rows[0][4].ToString();
            Literal1.Text = dt.Rows[0][1].ToString();
            Literal2.Text = dt.Rows[0][3].ToString();
            Literal3.Text = dt.Rows[0][2].ToString();

            dt.WriteXml("D:/A.xls");
        }
    }
}