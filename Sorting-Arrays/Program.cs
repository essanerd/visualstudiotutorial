using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {
                5,2,8,4,5,1,10,8,3,9
            };

            string test = "";
            test.Replace(" ", "");

            Array.Sort(numbers);

            foreach (int num in numbers) {
                Console.Write($"{num}  ");
            }

            Console.ReadLine();
        }
    }
}
