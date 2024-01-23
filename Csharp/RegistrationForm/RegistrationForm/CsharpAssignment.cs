using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Menu();
        }
        void Menu()
        {
            for (int i = 0; i < 100; i++) { Console.Write("-"); }
            Console.WriteLine();
            for (int i = 0; i < 100; i++) { Console.Write("-"); }
            Console.WriteLine();

            Console.WriteLine("Welcome!!!! Please Enter the Choice Given Below:-");
            Console.WriteLine("1 For Reading Contents of a File");
            Console.WriteLine("2 For Creating New File");
            Console.WriteLine("3 For Editing the file(Appending text to the existing text)");
            Console.WriteLine("4 For Deleting a File");
            Console.WriteLine("5 For Exit.");

            Console.WriteLine();
            for (int i = 0; i < 10; i++) { Console.Write("-"); }
            Console.WriteLine();
            for (int i = 0; i < 10; i++) { Console.Write("-"); }
            Console.WriteLine();

            Console.WriteLine("Enter Your Choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            CheckUserInput(choice);
        }
        void CheckUserInput(int choice)
        {
            do
            {
                switch (choice)
                {
                    case 1:
                        ReadFilesFromTheFolder();
                        break;
                    case 2:
                        CreateNewFile();
                        break;
                    case 3:
                        EditFiles();
                        break;
                    case 4:
                        DeleteFiles();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (YesOrNo() == 'Y');
        }
        void ReadFilesFromTheFolder()
        {
            Console.WriteLine("Enter The File Name with Extension");
            string userInput = Console.ReadLine();
            userInput = userInput.Trim();
            string output = "";
            try
            {
                output = File.ReadAllText(userInput);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                if (YesOrNo() == 'Y')
                {
                    Menu();
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Here are The Contents of The File.");
            string sentences = "";
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] != '.')
                {
                    sentences += output[i];
                }
                else
                {
                    Console.WriteLine(sentences);
                    sentences = "";
                }
            }
        }
        void CreateNewFile()
        {
            Console.WriteLine("Enter The Text You Want to keep in the File");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the Name Of The File With extension");
            string fileName = Console.ReadLine();
            fileName = fileName.Trim();
            File.WriteAllText(fileName, input);
            Console.WriteLine("File Created Successfully");
            if (YesOrNo() == 'Y')
                CreateNewFile();
            else
                Menu();
        }
        void EditFiles()
        {
            //method for editing files
        }
        void DeleteFiles()
        {
            Console.WriteLine("Enter The Name of The File With Extension");
            string input= Console.ReadLine();
            try
            {
                File.Delete(input);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Files Successfully Deleted");
            if(YesOrNo() =='Y')
            {
                Menu();
            }
        }
        char YesOrNo()//method to check whether the user has given yes or no.
        {
            Console.WriteLine("Do You Want To Continue? Y/N");
            char choiceForContinuation = Char.ToUpper(Console.ReadLine()[0]);
            switch (choiceForContinuation)
            {
                case 'Y':
                    return 'Y';
                case 'N':
                    return 'N';
                default:
                    Console.WriteLine("Invalid Input,Try Again");
                    YesOrNo();
                    return ' ';
            }
        }
    }
}

