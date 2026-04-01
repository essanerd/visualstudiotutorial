using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Scope
{
    internal class Program
    {
        class Person
        {

            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }



            public string ReturnDetails()
            {

                return $"name: {name}\nAge {age} ";
            }
        }

            static void Main(string[] args)
            {
                Person person = new Person("Aba", 23);
                Console.WriteLine(person.ReturnDetails());
            }
        
    }
}