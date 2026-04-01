using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Fields
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

            public void setName(string name)
            {
                if (!string.IsNullOrEmpty(name))
                {
                    this.name = name;
                }
                else { 
               this.name = "invalid";
                }
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

            //name = "harry";
            //age = 25;

            person.setName("harry");

          /*  person.name = null;
            if (person.name.Equals("aba")) { 
            
            }*/
            Console.ReadLine();
        }
    }
}
