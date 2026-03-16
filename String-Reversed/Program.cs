using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Reversed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your msg");
            string msg = Console.ReadLine();

            for (int i = 0; i < msg.Length; i++)
            {
                Console.WriteLine(msg[i]);
            }

            for (int i = msg.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(msg[i]);
            }
            Console.ReadLine();
        }
    }
}
