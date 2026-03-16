using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Clearing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            Array.Clear(numbers, 0, numbers.Length);

            foreach (var number in numbers) {
                    Console.WriteLine($"{number}");
            }

            Console.ReadLine();
        }
    }
}
