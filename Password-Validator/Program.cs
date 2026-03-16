using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a password");
            string password = Console.ReadLine();

            Console.WriteLine("enter password again");
            string passwordC = Console.ReadLine();


            Console.ReadLine();

            if (!password.Equals(string.Empty) && !passwordC.Equals(string.Empty))
            {
                if (password.Equals(passwordC)) {
                    Console.WriteLine("passwords match");
                }
                else {
                    Console.WriteLine("passwords do not match");
                }
            }
            
            else {
                Console.WriteLine("enter a password");
            }
        }
    }
}
