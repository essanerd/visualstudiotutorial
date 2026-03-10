using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 1000D / 12.34;
            Console.WriteLine(result);
            Console.WriteLine("{0:0.00}" , result);

            double money = 10D / 3D;

            Console.WriteLine(money);
            Console.WriteLine("${0:0.00}");
            Console.WriteLine(money.ToString("C"));

           // Console.WriteLine(money.ToString("C"));

        }
    }
}
