using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeWebApplication.DataAcesslayer;
namespace PracticeWebApplication.Businesslayer
{
    public class BusinessLayer
    {  
        public static DataSet disProduct()
        {
            string sStoreProcedure = "ShowLaptopDetails";
            try
            {
                return DataAcesslayer.DataAcessLayer.ExecuteDataSet(sStoreProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
