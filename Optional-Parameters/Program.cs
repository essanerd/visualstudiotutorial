using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5);
            Console.WriteLine(result);

            printname("joe");
            Console.ReadLine();
        }
        static void printname(string name) {
            Console.WriteLine($"my name is {name}");
        }
        static int Add(int a, int b = default) {
            return a + b;
        }
    }
}
