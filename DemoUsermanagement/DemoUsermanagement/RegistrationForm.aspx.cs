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
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCountryData();
            }
        }
        protected void BindCountryData()
        {
            //list of Type Country is Created to Bind Table Data
            List<Country> CountryDataTable = GetCountryData();
            Country.DataSource = CountryDataTable;
            Country.DataTextField = "CountryName";
            Country.DataValueField = "CountryID";
            Country.DataBind();
            Country.Items.Insert(0, new ListItem("Select Country", ""));

        }
        private List<Country> GetCountryData()
        {//Here List of Country type is created and each object of Country type is filled with row Data and then added to the List<country>
            List<Country> countries = new List<Country>();
            string connectionString = ConfigurationManager.ConnectionStrings["DemoDBConnection"].ConnectionString;
            DataTable countryDataTable = new DataTable();
            string query = "select * From Country";
            using (SqlConnection connectionToDB = new SqlConnection(connectionString))
            {
                connectionToDB.Open();
                SqlDataAdapter result = new SqlDataAdapter(query, connectionToDB);
                result.Fill(countryDataTable);
            }
            //each row data is stored in a new object of Student
            foreach (DataRow row in countryDataTable.Rows)
            {
                countries.Add(new Country
                {
                    CountryID = Convert.ToInt32(row["CountryId"]),
                    CountryName = row["CountryName"].ToString()
                });
            }
            return countries;
        }
        protected void CountryIndexChanged(Object sender, EventArgs e)
        {
            List<State> stateDataTable = GetStateData();
            State.DataSource = stateDataTable;
            State.DataTextField = "StateName";
            State.DataValueField = "StateID";
            State.DataBind();
            State.Items.Insert(0, new ListItem("Select Country", ""));
           
        }
        protected List<State> GetStateData()
        {
            List<State> states = new List<State>();
            string connectionString = ConfigurationManager.ConnectionStrings["DemoDBConnection"].ConnectionString;
            DataTable stateTable = new DataTable();
            int selectedValue = Convert.ToInt32(Country.SelectedValue);
            string query = "select * From State where CountryId=@CountryId;";
            using (SqlConnection connectionToDB = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connectionToDB))
                {
                    command.Parameters.AddWithValue("@CountryId", selectedValue);
                    connectionToDB.Open();
                    SqlDataAdapter result = new SqlDataAdapter(command);
                    result.Fill(stateTable);
                }
            }
            foreach (DataRow row in stateTable.Rows)
            {
                states.Add(new State
                {
                    StateID = Convert.ToInt32(row["StateId"]),
                    StateName = row["StateName"].ToString()
                });
            }
            return states;
        }
    }

    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
    }
    public class State
    {
        public int StateID { get; set; }
        public string StateName { get; set; }
        public int CountryID { get; set; }
    }
}