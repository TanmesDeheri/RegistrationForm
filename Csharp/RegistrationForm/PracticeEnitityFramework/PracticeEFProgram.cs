using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Objects;

namespace PracticeEnitityFramework
{
     class PracticeEFProgram
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DataBaseConnection"].ConnectionString;
            try
            {
                using(SqlConnection connectionToDB = new SqlConnection(connectionString))
                {
                    connectionToDB.Open();
                    ShowRelatedDataBetweenEmployeeAndDepartment(connectionToDB);
                }
                    ShowRelatedDataBetweenEmployeeAndDepartmentUsingEntityFramework();
                ShowEntityTypeOfEmployee();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        static void ShowRelatedDataBetweenEmployeeAndDepartment(SqlConnection connectionToDB)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Departments; SELECT * FROM Employees;", connectionToDB);
            DataSet dataSet = new DataSet();
            
            dataAdapter.Fill(dataSet);
            DataTable DepartmentDataTable = dataSet.Tables[0];
            DataTable EmployeeDataTable = dataSet.Tables[1];
            Console.WriteLine("This Is Done Without Using Entity Framework");
            foreach (DataRow row in DepartmentDataTable.Rows)
            {
                Console.WriteLine($"  Department = {row["Name"]}, Location = {row["Location"]}");
                DataView dataView = EmployeeDataTable.DefaultView;

                dataView.RowFilter = "DepartmentId = " + row["ID"];
                foreach (DataRowView rowView in dataView)
                {
                    DataRow emp = rowView.Row;
                    Console.WriteLine($"\t Name = {emp["Name"]}, Email = {emp["Email"]}, Gender = {emp["Gender"]}, salary = {emp["Salary"]}");
                }
            }
        }
        static void ShowRelatedDataBetweenEmployeeAndDepartmentUsingEntityFramework()
        {
            using (EF_Demo_DBEntities DBEntities = new EF_Demo_DBEntities())
            {
                List<Department> listDepartments = DBEntities.Departments.ToList();
                Console.WriteLine();
                Console.WriteLine("This Is Done Using Entity Framework");
                Console.WriteLine();
                foreach (Department dept in listDepartments)
                {
                    Console.WriteLine("  Department = {0}, Location = {1}", dept.Name, dept.Location);
                    foreach (Employee emp in dept.Employees)
                    {
                        Console.WriteLine("\t Name = {0}, Email = {1}, Gender = {2}, salary = {3}",
                            emp.Name, emp.Email, emp.Gender, emp.Salary);
                    }
                    Console.WriteLine();
                }
            }
        }
        static void ShowEntityTypeOfEmployee()
        {
            using(EF_Demo_DBEntities dBEntities = new EF_Demo_DBEntities())
            {
                var employee = dBEntities.Employees.Find(1);
                Console.WriteLine($"Dynamic Proxy For Employee: {employee}");
                var employeeType = ObjectContext.GetObjectType(employee.GetType());
                Console.WriteLine($"Wrapped Type By Dynamic Proxy: {employeeType}");
                Console.WriteLine($"FullName of Employee Master Type : {employeeType.FullName}");
                Console.WriteLine($"Name of Employee Master Type : {employeeType.Name}");
            }
        }
    }
}
