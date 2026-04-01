using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    bool sucess = false;

            //    try
            //    {

            //        Console.WriteLine("enter a number");
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        sucess = true;
            //    }

            //    catch (FormatException)
            //    {
            //        Console.WriteLine("FormatException");
            //    }

            //    Console.WriteLine(sucess ? "yay" : "oh no");

            Console.WriteLine("enter a number");
            if(tryParse(Console.ReadLine(), out int result)){

                Console.WriteLine("yey" + result);
            }
           else {

                Console.WriteLine("oh no");

            }
                Console.ReadLine();
            

        }

        static bool tryParse(string input, out int result) {
            result = -1;
            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception) { 
            return false;
            }
        }
    }
}