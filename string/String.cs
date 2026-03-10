using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Conversion
    {
        static void Main(string[] args)
        {
            //int x;
            //int y;
            //int z;

            // int x = 1, y = 2, z = 3;

            string Textage = "-23";
            int age = Convert.ToInt32(Textage);
            Console.WriteLine(age);

            string BigNumber1 = "9000000000";
            long BigNumber = Convert.ToInt64(BigNumber1);
            Console.WriteLine(BigNumber);

            string negative = "-55.2";
            double negative1 = Convert.ToDouble(negative);
            Console.WriteLine(negative1);

            string precission = "5.0001";
            float precicssion = Convert.ToSingle(precission);
            Console.WriteLine(precicssion);


            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            Console.ReadLine();

        }
    }
}

