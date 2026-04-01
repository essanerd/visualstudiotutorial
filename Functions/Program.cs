using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{

    class test {
        public static void something() {
            Console.WriteLine();
        }
    }
    internal class Program
    {

        
        static void Main(string[] args)
        {
            test.something();
            Console.ReadLine();
        }

        static void welcomemessage() {
            Console.WriteLine("welcome");
        }
    }
}
