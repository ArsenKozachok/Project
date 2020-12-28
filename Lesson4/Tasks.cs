using System;

namespace Task1
{
    public abstract class Figure
    {
        public abstract void Draw();
    }

    public class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("It's a Square class");
        }
    }

    public class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("It's a Rectangle class");
        }
    }
    class Program1
    {
        static void Main()
        {
            Square squarefigure = new Square();
            Rectangle rectanglefigure = new Rectangle();
            squarefigure.Draw();
            rectanglefigure.Draw();
        }
    }
} 

using System; 
 
namespace Task2
{
    public abstract class Figure
    {
        public abstract void Draw(); public readonly int _x, _y;
        protected Figure(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }

    public class Square : Figure
    {
        public Square(int x, int y)
            : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("It's a Square class");
        }
    }

    public class Rectangle : Figure
    {
        public Rectangle(int x, int y)
            : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("It's a Rectangle class");
        }
    }
    class Program
    {
        static void Main()
        {
            Square squarefigure = new Square(4, 4);
            Rectangle rectanglefigure = new Rectangle(2, 3);
            squarefigure.Draw();
            rectanglefigure.Draw();
            Console.WriteLine("Square edges : x = {0} y = {1}", squarefigure._x, squarefigure._y);
        }
    }
} 
 
using System; 
 
namespace Task3
{
    public class Figure
    {
        public virtual void Draw()
        {
            Console.WriteLine("It's figure class");
        }
        public readonly int _x; public readonly int _y;
        public Figure(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }

    public class Rectangle : Figure
    {
        public Rectangle(int x, int y)
            : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("It's a rectangle class.");
        }
    }

    public class Square : Figure
    {
        public Square(int x, int y)
            : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("It's a square class");
        }
    }

    class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle(2, 3);
            Square square = new Square(4, 4);
            Figure justfigure = new Figure(8, 12);
            rectangle.Draw();
            square.Draw();
            justfigure.Draw();
            Console.WriteLine("Square edges: x = {0} y = {1}", square._x, square._y);
        }
    }
} 

using System; 
 
namespace Task4
{
    public interface IDrawable
    {
        public void Draw();
    }
    public class Figure : IDrawable
    {
        public virtual void Draw()
        {
            Console.WriteLine("It's a Figure class");
        }
        public readonly int _x, _y;
        public Figure(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
    public class Rectangle : Figure
    {
        public Rectangle(int x, int y)
            : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("It's a Rectangle class");
        }
    }

    public class Square : Figure
    {
        public Square(int x, int y)
            : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("It is a Square class");
        }
    }

    class Program
    {
        static void Main()
        {
            Square square = new Square(2, 2);
            Rectangle rectangle = new Rectangle(2, 3);
            Figure justfigure = new Figure(4, 12);
            DrawAll(square, rectangle, justfigure);
        }
        private static void DrawAll(params IDrawable[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Draw();
            }
        }
    }
}