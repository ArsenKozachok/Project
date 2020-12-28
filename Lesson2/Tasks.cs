using System;
using System.Text.Encodings.Web;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string task;
            while (true)
            {
                Console.WriteLine("choose task[1-4]:");
                task = Console.ReadLine();
                switch (task)
                {
                    case "1": taskOne(); break;
                    case "2": taskTwo(); break;
                    case "3": taskThree(); break;
                    case "4": taskFour(); break;
                    default: Console.WriteLine("Wrong argument, try again"); break;
                }
            }

        }

        private static void taskOne()
        {
            Console.WriteLine("enter names: ");
            string str1 = Console.ReadLine();
            string str2 = str1.ToLower();
            Console.WriteLine(str2);
        }

        private static void taskTwo()
        {
            Console.WriteLine("enter first surname:");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter second  surname:");
            string str2 = Console.ReadLine();

            Console.WriteLine("These surnames are{0}", str1.Equals(str2, System.StringComparison.Ordinal) ? " equal" : " not equal");

            if (str1.Length > str2.Length)
            {
                Console.WriteLine("First surname is longer than the other");
            }
            else if (str1.Length < str2.Length)
            {
                Console.WriteLine("Second surname is longer than the other");
            }
            else
            {
                Console.WriteLine("Surnames have the same length");
            }

            Console.WriteLine("The first and the last characters in these surnames are {0}",
                (str1[0] == str2[0] && str1[str1.Length - 1] == str2[str2.Length - 1]) ? "equal" : "not equal");
        }

        private static void taskThree()
        {
            Console.WriteLine("enter line:");
            string str1 = Console.ReadLine();
            Console.WriteLine(str1.Replace('a', 'u'));
        }

        private static void taskFour()
        {
            Console.WriteLine("enter line:");
            string str1 = Console.ReadLine();
            string[] strArr = str1.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(strArr);
            foreach (string element in strArr)
            {
                Console.WriteLine(element);
            }

        }
    }
}