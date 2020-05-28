using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Square : IMeasurable
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

    }
}
