using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMS98361.Console.Polymorphsym
{
    class Triangle : Polygon
    {
        public override void Draw()
        {
            System.Console.WriteLine("Drawing: Triangle");
        }
    }
}
