using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    class Circle : Shape
    {
        public double Radius;

        public override double Area()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}
