using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunaconsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            

            Console.WriteLine("Just write your name:");
          
            name = Console.ReadLine();

            Console.WriteLine("Please enter you Age:");

            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your name is: " + name + " and you age is: "+ age);

            Console.WriteLine($"Your name is {name} and" +
                $"you are {age} years old: ");

            Console.ReadLine();
          
        }
    }
}
