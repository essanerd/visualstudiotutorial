using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            int age = 23;
            age++;
            age = age + 10;
            age += 10;
            Console.WriteLine(age);
            age--;
            age -= 10;
            Console.WriteLine(age);

            age *= 10;
            Console.WriteLine(age);

            age /= 10;// 2.3 -> 2
            Console.WriteLine(age);

            double age2 = 23;
            age2 /= 10;
            Console.WriteLine(age2);

            int i = 0;
            i++;
            ++i;
            Console.WriteLine(i++);
            Console.WriteLine(i);
            Console.WriteLine(++i);

            int firstnum = 10;
            int secondnum = 3;
            Console.WriteLine(firstnum / secondnum);
            Console.WriteLine(firstnum % secondnum);

            Console.WriteLine(1000 % 90);
            Console.WriteLine(100 % 90);
            Console.WriteLine(71 % 10);

            // Operators on string

            string name = "aba";
            name += " is programming";
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';// adds in unicode
            Console.WriteLine(ch);
            Console.ReadLine();
        }
    }
}
