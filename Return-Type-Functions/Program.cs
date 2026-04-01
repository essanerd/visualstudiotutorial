using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Return_Type_Functions
{
    internal class Program
    {
        static void Main(string[] args) {
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++) {
    //        numbers[i] = ReadNumberFromConsole;
            }
        
                Console.ReadLine();
        }

        static int ReadNumberFromConsole() {
            Console.WriteLine("enter a number");
            return Convert.ToInt32(Console.ReadLine());
        }
        static string ReturnName()
        {
            return "aba";
        }
        
        static void Printintroduction() {
            string name = "aba";
            int age = 23;
            Console.WriteLine($"my name is {name} and age is {age}");
        }

        static
    }
}
