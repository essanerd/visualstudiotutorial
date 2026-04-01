using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;
            int[] result = new int[length];
            int counter = 0;

            for (int i = 0; i < result.Length; i++)
            {
                result[counter] = num * i;
                counter++;
            }
            Console.ReadLine();
        }
    }
}
