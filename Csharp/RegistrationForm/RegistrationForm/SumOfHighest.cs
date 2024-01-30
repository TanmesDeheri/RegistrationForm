using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm
{
     class SumOfHighest
    {
        static void Main (String[] args) {
           var test = "23,45,21|09,33,98,,36,89,-11,09,4,100.5|33,89";
            var sumOfTopThree = test
    .Split('|')
    .SelectMany(group => group.Split(',')
                              .Where(s => !string.IsNullOrEmpty(s))
                              .Select(s => double.Parse(s)))
    .Distinct()
    .OrderByDescending(n => n)
    .Take(3)
    .Sum();
            Console.WriteLine("The Sum of Highest 3 numbers are "+sumOfTopThree);
            Console.ReadKey();
        }
    }
}
