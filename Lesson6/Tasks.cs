using System;
using System.Linq;

namespace _1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers: ");
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (int)Math.Pow(arr[i], 3);
            }
            Console.WriteLine("Array: ");
            Console.WriteLine("{0}", string.Join(", ", arr));
        }
    }
}

using System;
using System.Linq;

namespace _2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            static int Prime(int[] array)
            {
                int Primers = array.Length;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 1)
                    {
                        for (var j = 2u; j < array[i]; j++)
                        {
                            if (array[i] % j == 0)
                            {
                                Primers--;
                                break;
                            }
                        }
                    }
                    else Primers--;
                }
                return Primers;
            }

            {
                Console.WriteLine("Enter some numbers:");
                int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                Console.WriteLine("There are some prime numbers: {0} ", Prime(arr));
            }
        }
    }
}

using System;
using System.Linq;

namespace _3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Symetry(int[] array)
            {
                bool symetry = true;
                for (int i = 0; i < array.Length / 2; i++)
                {
                    if (array[i] == array[array.Length - i - 1])
                    {
                        symetry = true; continue;
                    }
                    else
                    {
                        symetry = false;
                        break;
                    }
                }
                if (symetry == true) Console.WriteLine("Array symetric.");
                else Console.WriteLine("Array not symetric");
            }
            {
                Console.WriteLine("Enter some numbers:");
                int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray(); Symetry(arr);
            }
        }
    }
}

using System;
using System.Linq;

namespace _4_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size: ");
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b number:");
            int b = int.Parse(Console.ReadLine());
            int[,] arr = new int[a, b];
            Console.WriteLine("\n Write some numbers ({0}x{1}):\n", a, b); for (int i = 0; i < a; i++)
            {
                int[] arr_ = new int[b];
                arr_ = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); for (int j = 0; j < arr_.Length; j++)
                {
                    arr[i, j] = arr_[j];
                }
            }

            Console.WriteLine("\n Your array:");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.Write("\n");
            }

            int[] vector = new int[a]; for (int i = 0; i < a; i++)
            {
                int max = arr[i, 0]; for (int j = 0; j < b; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                    vector[i] = (int)max;

                }
            }
            Console.WriteLine("Vector: " + "[" + "{0}", string.Join(", ", vector) + "]");
        }

    }
}

        using System;
using System.Linq;

namespace _5_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            Console.WriteLine("Enter number:");
            int m = int.Parse(Console.ReadLine());
            int[][] arr = new int[m][];
            Console.WriteLine("\nEnter elements of a array:");
            for (int i = 0; i < m; i++)
            {
                int[] arr_ = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); arr[i] = new int[arr_.Length]; for (int j = 0; j < arr_.Length; j++)
                {
                    arr[i][j] = arr_[j];
                }
            }
            Console.WriteLine("\nYour array:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0} ", arr[i][j]);
                }
                Console.Write("\n");
            }
            int[] vector = new int[m]; for (int i = 0; i < arr.Length; i++)
            {
                int max = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > max)
                    {
                        max = arr[i][j];
                    }
                    vector[i] = (int)max;
                }
            }
            Console.WriteLine("\nVector: " + "[" + "{0}", string.Join(", ", vector) + "]");
        }
    }
}