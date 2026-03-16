using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace String_Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "C# is awsome";
            for (int i = 0; i < msg.Length; i++)
            {
                Console.Write(msg[i]);
                Thread.Sleep(10);
            }
            //    Console.WriteLine();
            //    Console.WriteLine(msg.Contains("C"));

            //    bool containsC = false;

            //    for (int i = 0; i < msg.Length; i++) {
            //        if (msg[i].Equals('C'))
            //        {
            //            containsC = true;
            //        }
            //        else { containsC = false;
            //        }
            //    }
            //}
        }
    }
}