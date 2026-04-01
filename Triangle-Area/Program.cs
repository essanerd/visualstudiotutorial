using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = ReadInt("enter the width");
            int height = ReadInt("enter the height");
           Console.ReadLine();
        }

        static int calcArea(int width, int height) {
            return (width * height) / 2;
        }

        static int ReadInt(string msg) {
            Console.WriteLine(msg);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
