using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeBugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age = 35;

            //if (age > 18)
            //{

            //    Console.WriteLine("18+");
            //}
            //else if (age > 30) {
            //    Console.WriteLine("30+");
            //}

            string name = "aba";
            int age = 23;

            PrintDetails(name, age);

            string msg = ReadConsole("Enter anything:");

            Console.ReadLine();
        }

        static string ReadConsole(string msg) {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

        static void PrintDetails(string name, int age) {
            Console.WriteLine($"{name} - {age}");
        }
    }
}
