using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Square : IMeasurable, IComparable
    {
        private double sideSquare;
        public double SideSquare
        {
            get { return sideSquare; }
            set { sideSquare = value; }
        }
        public Square(double sideSquare)
        {
            this.sideSquare = sideSquare;
        }
        public double Perimeter()
        {
            return 4 * SideSquare;
        }
        public double Area()
        {
            return SideSquare * SideSquare;
        }
        public int CompareTo(object o)
        {
            Square square = o as Square;
            if (square != null)
                return this.Perimeter().CompareTo(square.Perimeter());
            else
                throw new Exception("Unable to compare two objects");
        }
    }
}
