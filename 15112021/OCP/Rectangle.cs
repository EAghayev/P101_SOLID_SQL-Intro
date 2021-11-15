using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    class Rectangle : Shape
    {
        public double Width;
        public double Height;

        public override double Area()
        {
            return this.Width * this.Height;
        }
    }
}
