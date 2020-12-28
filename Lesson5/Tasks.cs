using System;
namespace Task1
{
    public struct Person
    {
        public string _name, _surname;
        public int _age;
        public Person(string name, string surname, int age)
        {
            _name = name;
            _surname = surname;
            _age = age;
        }
        public string Old(int n)
        {
            if (n > _age)
            {
                return $"{_name} {_surname} younger than {n}";
            }
            else if (n < _age)
            {
                return $"{_name} {_surname} older than {n}";
            }
            else
            {
                return $"{_name} {_surname} is {_age} years old";
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Person person;
            string[] argument;
            int n;
            Console.WriteLine("Write name, surname, age: ");
            argument = Console.ReadLine().Split(' ');
            person = new Person(argument[0], argument[1], int.Parse(argument[2]));
            Console.WriteLine("Enter n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(person.Old(n));
            Console.ReadKey();
        }
    }
}

using System;
namespace Task2
{
    struct Rectangle : ICoordinate, ISize
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Rectangle(int width, int height, int x, int y)
        {
            Width = width;
            Height = height;
            this.X = x;
            this.Y = y;
        }
        public int GetPer(int width, int height)
        {
            return (width + height) * 2;
        }
    }

    internal interface ICoordinate
    {
    }

    internal interface ISize
    {
    }

    class Program
    {
        static void Main()
        {
            Rectangle rectangle;
            string[] param;
            int GetPer;
            Console.WriteLine("Write width, heigth, x and y coordinates: ");
            param = Console.ReadLine().Split(' ');
            rectangle = new Rectangle(int.Parse(param[0]), int.Parse(param[1]), int.Parse(param[2]), int.Parse(param[3]));
            GetPer = (int.Parse(param[0]) + int.Parse(param[1])) * 2;
            Console.WriteLine($"\nRectangle width: {rectangle.Width}");
            Console.WriteLine($"\nRectangle height: {rectangle.Height}");
            Console.WriteLine($"\nRectangle x : {rectangle.X}");
            Console.WriteLine($"\nRectangle y : {rectangle.Y}");
            Console.WriteLine($"\nPerimetr: {GetPer} ");
            Console.ReadKey();
        }
    }
}

using System;
namespace Task3
{
    enum Month { January, February, March, April, May, June, July, August, September, October, November, December };
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter month:");
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine("Month: {0}", Enum.GetName(typeof(Month), n));
        }
    }
}

using System;
namespace Task2
{
    enum Colors { Red = 4, Blue = 15, Brown = 9 }
    class Program
    {
        static void Main()
        {
            Extension.Color();
        }
    }
    public static class Extension
    {
        public static void Color()
        {
            foreach (Colors color in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine(color);
            }
        }
    }
}

using System;
namespace Task3
{
    enum LongRange : long { Max = 9223372036854775807, Min = -9223372036854775808 };
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Max: {0}", (long)LongRange.Max);
            Console.WriteLine("Min: {0}", (long)LongRange.Min);
        }
    }
}