using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> names = new Dictionary<int, string>
            //{
            //    {1,"essa" },
            //    {2,"test" },
            //    {3, "Test" }
            //};

            //for (int i = 0; i < names.Count; i++)
            //{
            //    KeyValuePair<int, string> pair = names.ElementAt(i);
            //    Console.WriteLine($"{pair.Key} - {pair.Value}");
            //}

            Dictionary<string, string> teachers = new Dictionary<string, string> {

                {"math", "aba" },
                {"science", "test" }


            };

            //  Console.WriteLine(teachers["math"]);

            //if (teachers.TryGetValue("math", out string teachers))
            //{
            //    teachers.Remove("math");
            //}
            //else
            //{
            //    Console.WriteLine("teacher not found");
            //}


            Console.ReadLine();
        }
    }
}
