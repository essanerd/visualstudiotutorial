using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = true;

            while (success)
            {

                Console.WriteLine("enter a number:");
                string numInput = Console.ReadLine();
                int num = 0;



                if (int.TryParse(numInput, out num))
                {

                    Console.WriteLine(num);
                    success = false;
                }
                else
                {
                    Console.WriteLine("Failed To Convert");
                }
                Console.ReadLine();
            }
        }
    }
}
