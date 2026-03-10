using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int age = 23;
           var age = 23
            Console.WriteLine(age);
          
            var BigNumber = 9000000000L;
            Console.WriteLine(BigNumber);

            var negative = -55.2D;
            Console.WriteLine(negative);

            var precicssion = 5.0001F;
            Console.WriteLine(precicssion);

            var money = 14.99M;
            Console.WriteLine(money);

            var name = "aba";

            var letter = 'a';

            Console.ReadLine();
        }
    }
}
