using System;

namespace Structures
{
    internal class Program
    {
        struct Person
        {
            public string name;
            public int age;
            public int birthmonth;
            public int number;

            public Person(int age, string name, int birthmonth, int number)
            {
                this.age = age;
                this.name = name;
                this.birthmonth = birthmonth;
                this.number = number;
            }
        }

        static void Main(string[] args)
        {
        //    string newname = "";
        //    int newage = 0;
        //    int newbirthmonth = 0;
        //    ReturnPerson(ref newname, ref newage, ref newbirthmonth);

        //    int birthmonth = 5;

        //    Person person;
        //    person.name = "Aba";
        //    person.age = 23;
        //    person.birthmonth = 5;

            Person person = ReturnPerson();
            Console.WriteLine($"{person.name} - {person.age} - {person.birthmonth} - {person.number}");

            Console.ReadLine();
        }

        static Person ReturnPerson() {

                Console.WriteLine("Enter a name:");
               string name = Console.ReadLine();

                Console.WriteLine("Enter age:");
             int   age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter birthmonth:");
            int  birthmonth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number:");
            int  number = Convert.ToInt32(Console.ReadLine());

            Person person;

            person.age = age;
            person.birthmonth = birthmonth;
            person.name = name;
            person.number = number;

            return person;
        }


        //static void ReturnPerson(ref string name, ref int age, ref int birthmonth)
        //{
        //    Console.WriteLine("Enter a name:");
        //    name = Console.ReadLine();

        //    Console.WriteLine("Enter age:");
        //    age = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Enter birthmonth:");
        //    birthmonth = Convert.ToInt32(Console.ReadLine());
        //}
        //  }
    }
}