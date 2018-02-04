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
            Rectangle rect = new Rectangle(10.0,20.0);
            double area = rect.GetArea();
            System.Console.WriteLine($"El area del rectangulo es {area}");
            System.Console.ReadLine();

        }
    }
}
