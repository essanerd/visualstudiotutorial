using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "aba";

            Console.Write("what is your name:");
            string username = Console.ReadLine();
            Console.WriteLine(username);

            Console.WriteLine("waht is youe age");
            string  age = Console.ReadLine();
            Console.WriteLine(age);
            int age2 = Convert.ToInt32(age);


            Console.WriteLine("your name is " + username + " your age is " + age);

            Console.ReadLine();
        }
    }
}
