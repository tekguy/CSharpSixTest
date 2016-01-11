using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSixTest
{
    class Program
    {
        public static string FirstName { get; set; }
        public static string LastName { get; set; }

        public static string FullName => $"{FirstName} {LastName}";

        static void Main(string[] args)
        {
            FirstName = "John";
            LastName = "Doe";
            Console.WriteLine(FullName);

        }
    }
}
