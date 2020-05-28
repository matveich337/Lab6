using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(18.5);
            Console.WriteLine(square1.SideSquare);
            Console.WriteLine("Perimeter = " + square1.Perimeter());
            Console.WriteLine("Area = " + square1.Area());
        }
    }
}