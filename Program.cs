using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Class_Activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey, what is your name? ");
            string name = Console.ReadLine();

            Console.Write("Hi " + name + ", when were you born? ");
            int yearOfBirth = int.Parse(Console.ReadLine());

            int age = 2023 - yearOfBirth;

            Console.WriteLine();
            Console.WriteLine(name + " is " + age + " years old.");
            Console.ReadKey();
        }
    }
}
