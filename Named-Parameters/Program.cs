using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameInput = "aba";
            int ageInput = 23;
            string adressInput = "1 something road";

            details(name:nameInput, age:ageInput, adress:adressInput);
            Console.ReadLine();
        }

        static void details(string name, int age, string adress) {
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"age: {23}");
            Console.WriteLine($"adress:{adress}");
        }
    }
}
