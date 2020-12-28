using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int taskNumber = 0;
            while (true)
            {
                Console.WriteLine("Choose task [1-6]:");
                int.TryParse(Console.ReadLine(), out taskNumber);
                switch (taskNumber)
                {
                    case 1:
                        Console.WriteLine("Opening task 1...");
                        taskOne();
                        break;
                    case 2:
                        taskTwo();
                        Console.WriteLine("Opening task 2...");
                        break;
                    case 3:
                        Console.WriteLine("Opening task 3...");
                        taskThree();
                        break;
                    case 4:
                        Console.WriteLine("Opening task 4...");
                        taskFour();
                        break;
                    case 5:
                        Console.WriteLine("Opening task 5...");
                        taskFive();
                        break;
                    case 6:
                        Console.WriteLine("Opening task 6...");
                        taskSix();
                        break;
                    default:
                        Console.WriteLine("Wrong number, try again");
                        break;

                }

            }
        }


        private static void taskOne()
        {
            double radius = getNumberFromConsole("Enter circle radius:");
            Console.WriteLine("Circle square is: " + Math.Pow(radius, 2) * Math.PI);
            return;
        }

        private static void taskTwo()
        {
            double sideLength = getNumberFromConsole("Enter cube side length:");
            Console.WriteLine("Cube volume is: " + Math.Pow(sideLength, 3));
            return;
        }

        private static void taskThree()
        {
            int m;
            int n;
            while (true)
            {
                m = (int)getNumberFromConsole("Enter number m [2-4]:");
                n = (int)getNumberFromConsole("Enter number n [2-4]:");
                if (n > 1 && n < 5 && m > 1 && m < 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Arguments must be in range [2-4]");
                }
            }
            Console.WriteLine(Math.Pow(m, n));
            return;
        }

        private static void taskFour()
        {
            double number = getNumberFromConsole("Enter your number:");
            Console.WriteLine("Integer number:" + (int)number);
            Console.WriteLine("Rounded number:" + Math.Round(number));
            return;
        }

        private static void taskFive()
        {
            double number;
            Boolean isSimple = false;
            while (true)
            {
                isSimple = true;
                number = (int)getNumberFromConsole("Enter your number [more than 2, siple]: ");
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        isSimple = false;
                        break;
                    }
                }
                if (number > 2 && isSimple)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Argument must be simple and more than 2 ");
                }
            }
            Console.WriteLine("Your halfnumber is: " + String.Format("{0:0.00}", number / 2, 2));
            return;

        }

        private static void taskSix()
        {
            double d;
            while (true)
            {
                d = getNumberFromConsole("Enter number d [more than 0]:");
                if (d > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Number d must be more than 0");
                }
            }
            Console.WriteLine("Square root of S is: " + Math.Sqrt((int)++d));
            return;
        }

        private static double getNumberFromConsole(string message)
        //this function read number from console and returns it
        {
            double numberFromConsole;
            while (true)
            {
                Console.WriteLine(message);
                if (double.TryParse(Console.ReadLine(), out numberFromConsole))
                {
                    return numberFromConsole;
                }
                else
                {
                    Console.WriteLine("wrong argument, try again.");
                }
            }
        }
    }
}