using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many times do you want to say hi");
            int counter = Convert.ToInt32(Console.ReadLine());
            if (counter <= 0)
            {
                Console.WriteLine("invaild");
            }

            else
            {
                for (int i = 0; i < counter; i++)
                {
                    Console.WriteLine("hi");
                }
            }
      /*      for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }*/

            Console.ReadLine();

        }
    }
}