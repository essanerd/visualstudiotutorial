using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnery_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = -12;

            string result = age >= 18 ? "You are an adult." : "You are a minor.";
            Console.WriteLine(result);

        }
    }
}
