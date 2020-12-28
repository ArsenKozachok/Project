using System;
using System.Numerics;

namespace Task1
{
    class Rectangle
    {
        private double Perimeter, Area;
        public int x1, x2, y1, y2;
        private int Width, Length;
        public void Param()
        {
            Console.WriteLine("Write x1 coordinate: ");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write y1 coordinate: ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write x2 coordinate: ");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write y2 coordinate: ");
            y2 = int.Parse(Console.ReadLine());
            Width = x2 - x1;
            Length = y1 - y2;
        }

        public void RectanglesPerimeter()
        {
            Perimeter = 2 * (Width + Length);
            Console.WriteLine("Area: {0}", Perimeter);
        }
        public void RectanglesArea()
        {
            Area = Width * Length;
            Console.WriteLine("Rectangle's area is {0}", Area);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Param();
            rectangle.RectanglesPerimeter();
            rectangle.RectanglesArea();
        }
    }
}

using System;

namespace Task2
{
    class Rectangle
    {
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }

        double Perimeter, Area;
        int Width, Lenghth;

        public Rectangle(int x1, int y1, int x2, int y2)
        {
            Width = x2 - x1;
            Lenghth = y1 - y2;
        }

        public void RectanglePerimeter()
        {
            Perimeter = 2 * (Width + Lenghth);
            Console.WriteLine("Rectangle's perimeter: {0}", Perimeter);
        }

        public void RectangleArea()
        {
            Area = Width * Lenghth;
            Console.WriteLine("Rectangle's area: {0}", Area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] coordinates = new int[4];
            Console.WriteLine("Write x1 coordinate: ");
            coordinates[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Write y1 coordinate: ");
            coordinates[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Write x2 coordinate: ");
            coordinates[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Write y2 coordinate: ");
            coordinates[3] = int.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(coordinates[0], coordinates[1],
            coordinates[2], coordinates[3]);
            rect.RectanglePerimeter();
            rect.RectangleArea();
        }
    }
}

using System;

namespace Task3
{
    class Circle
    {
        public int Radius { get; set; }
        private double Lenght, Area;
        const double Pi = 3.14;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public void CircleLenght()
        {
            Lenght = 2 * Pi * Radius;
            Console.WriteLine("Circle's lenght: {0}", Lenght);
        }

        public void CircleArea()
        {
            Area = Pi * Radius * Radius;
            Console.WriteLine("Circle's area: {0}", Area);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write radius circle: ");
            int radius = int.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            circle.CircleLenght();
            circle.CircleArea();
        }
    }
}