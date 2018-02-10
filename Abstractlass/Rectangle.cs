using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMS98361.Console.Abstractlass
{
    class Rectangle : Polygon
    {
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public override double GetArea()
        {
            return Width * Length;
        }
    }
}
