using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace If_Statments
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.Write("what is your name:");
            //string username = Console.ReadLine();
            //Console.WriteLine(username);

            //Console.WriteLine("what is youe age");
            //string age = Console.ReadLine();
            //int age2 = Convert.ToInt32(age);


            //Console.WriteLine("your name is " + username + " your age is " + age);

            //            if (age2 >= 18 && age2 <= 24){

            //  Console.WriteLine("you are 18 or older");
            //}
            //else if (age2 >= 25) {
            //    Console.WriteLine(" you are older than 25");
            //  }

            //if (age2 < 0 || age2 > 150)
            //{
            //    Console.WriteLine("age is invalid");
            //}
            //else
            //{
            //    Console.WriteLine("Vailid Age");
            //}

            Console.WriteLine("Enter first number");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.WriteLine("Enter second number");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberAInput);

            Console.WriteLine("The value of " + numberA + "x " + numberB + " = : ");
            string result = Console.ReadLine();
            int resultA = Convert.ToInt32(result);
            
            int ActualAnswer = numberA * numberB;

            if (resultA == ActualAnswer) {
                Console.WriteLine("well done!");
            }
            else
            {
                Console.WriteLine("ERR! try again");
            }

            Console.ReadLine();
        }
    }
}
