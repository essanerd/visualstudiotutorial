using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }

        static void CreateAndPrintArray()
        {
            int[] nums = new int[5] { 0, 1, 2,3,4 };

            foreach (var item in nums) {
                Console.WriteLine($"{item}");
            }
        }
    }
}
