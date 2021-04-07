using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_C_Sharp_Ch12
{
    class Hexagon : Shapes
    {
        //Fields
        private double side = 1.0;
        

        //Constructors
        public Hexagon(double side, string color)
        {
            this.side = side;
        }

        //Methods

        public override double GetPerimeter()
        {
            return 6.0 * side;
        }

        public override double GetArea()
        {
            return 3.0 * Math.Sqrt(3.0) * side * side / 2.0;
        }

    }
}
