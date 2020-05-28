using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Square[] squares = new Square[3];
            squares[0] = new Square(15);
            squares[1] = new Square(110);
            squares[2] = new Square(3);
            Array.Sort(squares);
            foreach(Square obj in squares)
            {
                Console.WriteLine("Side = " + obj.SideSquare);
                Console.WriteLine("Perimeter = " + obj.Perimeter());
            }

        }
    }
}
