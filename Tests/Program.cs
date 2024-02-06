using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class Program
    {

        enum Nedel: byte
        {
            sundy = 0,
            mundy = 1,
            friz
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Console.Write("Enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1}", name,age);
            
            Console.Write("Enter your birthdate: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine($"Your birthdate is: {birthdate}");
            Console.ReadKey();
        }
    }
}
