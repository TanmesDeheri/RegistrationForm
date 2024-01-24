using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RegistrationForm
{
     class DataOperation
    {
        static void Main(string[] args)
        {
            new DataOperation().RetrieveData();
            Console.ReadKey();//its basically used to tell the console to open the the window environment.
        }
        public void RetrieveData()
        {
            SqlConnection connectionToDataBase = null;
            try
            {
                connectionToDataBase = new SqlConnection("Data Source=.;database=AdventureWorks2022;Integrated Security=SSPI");
                SqlCommand retrieveData = new SqlCommand("SELECT TOP 50 FirstName,LastName FROM Person.Person", connectionToDataBase);
                connectionToDataBase.Open();
                SqlDataReader showData = retrieveData.ExecuteReader();
                while(showData.Read())
                {
                    Console.WriteLine(showData["FirstName"]+"\t\t" +showData["LastName"]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connectionToDataBase.Close();
            }

        }
    }
}
