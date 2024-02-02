using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEnitityFramework
{
    internal class AddEntry
    {
        public enum ChoiceValue
        {
            Display = 1,
            Add = 2
        }
        public static void Main(string[] args)
        {
            new AddEntry().ShowMenu();
            Console.ReadKey();

        }
        void ShowMenu()
        {
            try
            {
                Console.WriteLine("Enter The Choice Given Below:");
                Console.WriteLine($"{(Int32)ChoiceValue.Display} For Display Student Record");
                Console.WriteLine($"{(Int32)ChoiceValue.Add} For Adding A Student Record");
                int choice = Convert.ToInt32(Console.ReadLine());
                var choiceEnum = (ChoiceValue)choice;
                switch (choiceEnum)
                {
                    case ChoiceValue.Display:
                        Console.WriteLine("Displaying Student Table");
                        DisplayRecord();
                        break;
                    case ChoiceValue.Add:
                        Console.WriteLine("Adding Record to Student table");
                        UserInput();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void DisplayRecord()
        {
            try
            {
                using (EF_Demo_DBEntities context = new EF_Demo_DBEntities())
                {
                    List<Student> studentsList = context.Students.ToList();
                    foreach (Student student in studentsList)
                    {
                        Console.WriteLine($"StudentID: {student.StudentId} \t FirstName: {student.FirstName} \t LastName: {student.LastName}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        void UserInput()
        {
            Console.WriteLine("Enter The StudentID:");
            int studentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The FirstName:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter The LastName:");
            string lastName = Console.ReadLine();
            //Console.WriteLine("Enter The StandardID:");
            //int standardID=Convert.ToInt32(Console.ReadLine());
            Hashtable storeInput = new Hashtable();
            storeInput.Add("studentID", studentID);
            storeInput.Add("firstName", firstName);
            storeInput.Add("lastName", lastName);
            //storeInput.Add("standardID", standardID);
            AddRecordToTheTable(storeInput);
        }
        void AddRecordToTheTable(Hashtable storedInput)
        {
                using (EF_Demo_DBEntities context = new EF_Demo_DBEntities())
                {
                    Student studentDetails = new Student
                    {
                        FirstName = storedInput["firstName"].ToString(),
                        LastName = storedInput["lastName"].ToString(),
                        StudentId = Convert.ToInt32(storedInput["studentID"]),
                        //StandardId = Convert.ToInt32(storedInput["standardID"])
                    };
                    context.Students.Add(studentDetails);
                    context.SaveChanges();
                }
            Console.WriteLine("Record Has been Added");
        }
    }
}
