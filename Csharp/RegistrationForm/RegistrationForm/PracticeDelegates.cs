using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RegistrationForm
{
    class PracticeDelegates
    {
        public delegate void MethodForDelegate();
        public static void Main(string[] args)
        {
            MethodForDelegate del = new MethodForDelegate(Test);
            PracticeClass.MethodCallFromPracticeDelegates(del);
        }

        private static void Test()
        {
            Console.WriteLine("Hi , This is a Test Method");
        }
    }
    class PracticeClass
    {
        public static void MethodCallFromPracticeDelegates(MethodForDelegate del)
        {
            del.invoke();
        } 
    }
}
