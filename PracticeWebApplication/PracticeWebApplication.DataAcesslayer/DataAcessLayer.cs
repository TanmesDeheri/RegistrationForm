using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PracticeWebApplication.DataAcesslayer
{
    public class DataAcessLayer
    {
        public static DataSet ExecuteDataSet(string SPName)
        {
            string query = ConfigurationManager.ConnectionStrings["TestDBConnection"].ConnectionString;
            try
            {
                DataSet dsresult = new DataSet();
                using (SqlConnection connect = new SqlConnection(query))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(SPName.Trim(), connect);
                    cmd.CommandTimeout = 0;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsresult);
                    return dsresult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }
    }
}
