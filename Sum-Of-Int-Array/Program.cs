using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_Int_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {

              0,1,2,3,4,5
            };
            Sumofnumbers(numbers);
            Console.ReadLine();
        }

        static int Sumofnumbers(int[] numbers) {

            if (numbers.Length > 0)
            {

                int total = 0;

                foreach (var item in numbers)
                {

                    total += item;

                }

                return total;
            }
            return -1;
        }
    }
}
