using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vat = 20;
            vat = 10;

            const int vat2 = 20;
            //  vat2 = 10;
            Console.WriteLine(vat);
            Console.WriteLine(vat2);
            const double percentVAT = vat2 / 100D;
            int balance = 1000;
            Console.WriteLine(balance * percentVAT);
            Console.ReadLine();          
        }
    }
}
