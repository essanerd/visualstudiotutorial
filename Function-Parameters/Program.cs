using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Function_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(50,50));
            int num = ReadInt("enter a number");

            int angle = ReadInt("angle");
            Console.ReadLine();

            int FirstNum = ReadInt("enter first number");
            int secondNum = ReadInt("enter second number");
        }

        static int ReadInt(string message) {
            Console.WriteLine($"{message}");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int Add(int a, int b)
        {
            return a + b; 
        }
    }
}
