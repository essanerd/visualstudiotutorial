using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Auto_Window
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "aba";
            int age = 23;

            PrintDetails(name, age);

            string msg = ReadConsole("Enter anything:");

            Console.ReadLine();
        }

        static string ReadConsole(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

        static void PrintDetails(string name, int age)
        {
            Console.WriteLine($"{name} - {age}");
        }

       
        }
    }

