using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Times_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string numInput = Console.ReadLine();
            int num = Convert.ToInt32(numInput);

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
            }

            Console.ReadLine();

        }
    }
}
