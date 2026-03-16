using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {
                90, 199, 22 ,50, 30
            };

            Console.WriteLine("Which number do you want to search");
            int search = Convert.ToInt32(Console.ReadLine());

          int position =  Array.IndexOf(numbers, search);

            if (position > -1)
            {
                Console.WriteLine($"number {search} has benn found at {position + 1}");
            }

            else
            {
                Console.WriteLine("Number is not found");
            }

            Console.ReadLine();
        }
    }
}
