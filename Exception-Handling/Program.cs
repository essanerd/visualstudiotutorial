using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("enter a number");
                int num = Convert.ToInt32(Console.ReadLine());

            }

            catch (OverflowException) {
                Console.WriteLine("overFlow Excpetion");
            }

            catch (FormatException) {
                Console.WriteLine("FormatException");
            }
            catch (Exception) {
                Console.WriteLine("something has went wrong");
            }

            Console.ReadLine();
        }
    }
}
