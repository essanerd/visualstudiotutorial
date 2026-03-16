using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "hello";
            string compare = "hello";

            if (msg == compare)
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("diff");

            }

            Console.WriteLine("enter ur name");
            string name = Console.ReadLine();

            Console.ReadLine();

            if (!name.Equals(""))
            {
                Console.WriteLine("your name is " + name);
            }
            else
            {
                Console.WriteLine("invalid");
            }

            char[] chars = new char[] { 'h', 'e', 'l', 'l', 'o' };
            object obj = new string(chars);

            if (msg.Equals(obj))
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("diff");
            }
        }
    }
}
