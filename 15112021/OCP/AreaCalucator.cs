using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    class AreaCalucator
    {
        public double Area(Shape[] shapes)
        {
            double area = 0;

            foreach (var item in shapes)
            {
                area += item.Area();
            }

            return area;
        }
    }
}
