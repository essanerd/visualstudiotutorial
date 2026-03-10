using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Essa";
            int age = 23;

            Console.WriteLine("My name is " + name + " and I am " + age + " years old");
            Console.WriteLine($"My name is  {name} and I am   {age}  years old");
            // Test
        }
    }
}
