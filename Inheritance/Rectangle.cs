namespace ExamMS98361.Console.Inheritance
{
    class Rectangle : Polygon
    {
        public Rectangle(double length, double width)
        {
            Width = width;
            Length = length;
        }

        public double GetArea()
        {
            return Width * Length;
        }
    }
}
