using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMS98361.Console.Abstractlass
{
    abstract class Polygon
    {
        public double Length { get; protected set; }

        public double Width { get; protected set; }

        abstract public double GetArea();
    }
}
