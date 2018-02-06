using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExamMS98361.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            CustomEvents events = new CustomEvents();
            //rect.Length = 10.0;
            //rect.Width = 12.0;
            //double area = rect.GetArea();
            //System.Console.WriteLine($"El area del rectangulo es {area}");
            //System.Console.ReadLine();

            //rect.Changed += R_Changed;
            //rect.Length = 12;

            //events.changes += R_CustomChanges;
            events.Name = " ";
            Point point = new Point();
            point.X = 10;
            point.Y = 20;
            System.Console.WriteLine($"El resultado es {point.Multiplicity()}");

            System.Console.ReadLine();


        }

        public static void R_Changed(object sender, EventArgs e)
        {
            Rectangle r = (Rectangle)sender;
            System.Console.WriteLine("Value Changed: Length = {0}",r.Length);
        }

        public struct Point
        {
            private double x;
            private double y;

            public double X { get => x; set => x = value; }
            public double Y { get => y; set => y = value; }

            public double GetSum()
            {
                return x + y;
            }

            public double Multiplicity()
            {
                return x * y;
            }
        }
    }
}
