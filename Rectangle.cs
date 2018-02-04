using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMS98361.Console
{
    class Rectangle
    {
        private double width;
        private double length;



        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value >0.0)
                width = value;
            }
        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0.0)
                    length = value;
            }
        }

        /// <summary>
        /// Calcula el area del rectangulo
        /// </summary>
        /// <returns>Retorna un numero del tipo Double correspondiente 
        /// al valor del area del rectangulo</returns>
        public double GetArea()
        {
            return width * length;
        }
    }
}
