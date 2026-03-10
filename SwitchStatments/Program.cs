using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number 1 - 7");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("mon");
                    break;
                case 2:
                    Console.WriteLine("tue");
                    break;
                case 3:
                    Console.WriteLine("wed");
                    break;
                case 4:
                    Console.WriteLine("Thurs");
                    break;
                case 5:
                    Console.WriteLine("Fri");
                    break;
                case 6:
                    Console.WriteLine("sat");
                    break;
                case 7:
                    Console.WriteLine("sun");
                default: Console.WriteLine("invalid");
                    

                    break;


            }

            Console.ReadLine();
        }
    }
}
