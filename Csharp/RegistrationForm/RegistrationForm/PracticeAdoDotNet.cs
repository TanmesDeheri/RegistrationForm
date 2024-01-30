using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;

namespace RegistrationForm
{
    class PracticeAdoDotNet
    {
        static void Main(string[] args)
        {
            try 
            { 
            using (SqlConnection connectionToDB=new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ConnectionString))
            {
                    connectionToDB.Open();
                    Console.WriteLine("1st Method");
                    ShowStoredProcedure(connectionToDB);//Method For Stored Procedure
                    Console.WriteLine();
                    Console.WriteLine("2nd Method");
                    ShowAccountNumber(connectionToDB);//Method For 2nd Stored Procedure
                    Console.WriteLine();
                    Console.WriteLine("3rd Method");
                    ShowEmailAndPasswordHash(connectionToDB);
                    Console.WriteLine();
            };
            }
            catch(Exception ex)
            {
                string path = ConfigurationManager.AppSettings["LogFilePath"];
                string LogFileTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ");
                using (StreamWriter sw=File.AppendText(path))
                    {
                    sw.WriteLine(LogFileTime+" :- "+ex);//Error/Exception message is written on the LogFile.txt
                };
                StoreErrorInTable(LogFileTime,ex);//method to store error in table
                Console.WriteLine("Error: "+ex.Message);
            }
                Console.ReadKey();
        }
        static void ShowStoredProcedure(SqlConnection connectionToDB)
        {
                    SqlCommand command = new SqlCommand()
                    {
                        Connection = connectionToDB,
                        CommandText="NameLoginEndDate",
                        CommandType= CommandType.StoredProcedure
                    };
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["FirstName"] + "\t" + reader["LastName"] + "\t" + reader["LoginID"] + "\t" + reader["EndDate"]);
                    }
                    reader.Close();
        }
        static void ShowAccountNumber(SqlConnection connectionToDB)
        {
            Console.WriteLine("Enter The Customer ID:");
            int customerId=Convert.ToInt32(Console.ReadLine());
            if(customerId > 0)
            {
                SqlParameter parameter = new SqlParameter { 
                ParameterName = "CustomerId",
                SqlDbType = SqlDbType.Int,
                Value = customerId,
                Direction= ParameterDirection.Input,
                };

                SqlCommand command = new SqlCommand()
                {
                    Connection = connectionToDB,
                    CommandText = "SalesCustomerAccountNumber",
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.Add(parameter);

                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    Console.WriteLine("CustomerId: " + reader["CustomerID"]);
                    Console.WriteLine("StoreId: " + reader["StoreID"]);
                    Console.WriteLine("CustomerId: " + reader["CustomerID"]);
                    Console.WriteLine("TerritoryId: " + reader["TerritoryID"]);
                    Console.WriteLine("RowGuide: " + reader["rowguid"]);
                    Console.WriteLine("AccountNumber: " + reader["AccountNumber"]);
                }
                else
                {
                    Console.WriteLine("CustomerId Does'nt Exist !!!");
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Invalid CustomerId");
            }
        }
        static void ShowEmailAndPasswordHash(SqlConnection connectionToDB)
        {
            SqlDataAdapter retrieveData = new SqlDataAdapter("SELECT TOP 50 * FROM Person.EmailAddress;SELECT TOP 50 * FROM Person.Password", connectionToDB);
            DataSet dataSet=new DataSet();
            retrieveData.Fill(dataSet);
            DataTable emailAddress = dataSet.Tables[0];
            DataTable passwordHash = dataSet.Tables[1];
            foreach(DataRow row in emailAddress.Rows)
            {
                Console.Write($"Business Entity ID: {row["BusinessEntityID"]} \t Email Address: {row["EmailAddress"]} \t");
                DataView dataView = passwordHash.DefaultView;
                dataView.RowFilter = "BusinessEntityID = " + row["BusinessEntityID"];
                foreach(DataRowView rowView in dataView)
                {
                    DataRow passwd = rowView.Row;
                Console.Write($"PasswordHash: {passwd["PasswordHash"]} \t PasswordSalt: {passwd["PasswordSalt"]} \t");
                }
                Console.WriteLine();
            }
        }
        static void StoreErrorInTable(string LogFileTime,Exception ex)
        {

        }
    }
}

/* Given Procedure
CREATE PROCEDURE NameLoginEndDate AS 
select Person.Person.FirstName, Person.Person.LastName, HumanResources.Employee.LoginID,
HumanResources.EmployeeDepartmentHistory.EndDate 
from ((HumanResources.Employee inner join Person.Person
on HumanResources.Employee.BusinessEntityID=Person.BusinessEntityID)
inner join HumanResources.EmployeeDepartmentHistory
on HumanResources.Employee.BusinessEntityID=HumanResources.EmployeeDepartmentHistory.BusinessEntityID)
where HumanResources.EmployeeDepartmentHistory.EndDate is not null*/

/*CREATE PROCEDURE SalesCustomerAccountNumber(@CustomerId INT) AS
SELECT * FROM Sales.Customer WHERE CustomerID=@CustomerId;*/