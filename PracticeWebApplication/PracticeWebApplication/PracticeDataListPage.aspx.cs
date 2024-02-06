using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeWebApplication
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowDataFromDataList(sender, e);
            ShowDataFromDataGrid(sender,e);
        }
        protected void ShowDataFromDataList(object sender,EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Email");
            table.Rows.Add("101", "Sachin Kumar", "sachin@example.com");
            table.Rows.Add("102", "Peter", "peter@example.com");
            table.Rows.Add("103", "Ravi Kumar", "ravi@example.com");
            table.Rows.Add("104", "Irfan", "irfan@example.com");
            DataList1.DataSource = table;
            DataList1.DataBind();

        }//Method uses DataList
        protected void ShowDataFromDataGrid(object sender,EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Email");
            table.Rows.Add("101", "Deepak Kumar", "deepak@example.com");
            table.Rows.Add("102", "John", "john@example.com");
            table.Rows.Add("103", "Subramanium Swami", "subramanium@example.com");
            table.Rows.Add("104", "Abdul Khan", "abdul@example.com");
            DataGrid1.DataSource = table;
            DataGrid1.DataBind();
        }//Method Uses DataGrid
    }
}