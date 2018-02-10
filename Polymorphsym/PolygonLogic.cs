using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMS98361.Console.Polymorphsym
{
    class PolygonLogic
    {
        private List<Polygon> polygons = new List<Polygon>();

        internal void DrawPolygon()
        {
            polygons.Add(new Polygon());
            polygons.Add(new Rectangle());
            polygons.Add(new Triangle());

            foreach (var item in polygons)
            {
                item.Draw();
            }
        }
    }
}
