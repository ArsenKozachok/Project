using System;
using System.Collections.Generic;

namespace _1_2_task
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PersonNumbers { get; set; }
        public Person(string name, int age, IEnumerable<string> personNumbers)
        {
            Name = name;
            Age = age;
            PersonNumbers = personNumbers;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> List = new List<Person>
            {
                new Person("Amanda", 9, new List<string>() { "1", "2" }),
                new Person("Anton", 10, new List<string>() { "3", "4" }),
                new Person("Basia", 11, new List<string>() { "5", "6" }),
                new Person("Me", 12, new List<string>() { "7", "8" }),
                new Person("Ivan", 13, new List<string>() { "9", "10" })
            };
            foreach (var Person in List)
            {
                Console.WriteLine("\n Name: " + Person.Name + " " + "Age: " + Person.Age);
            }
            Console.WriteLine("\n Using the AddRange");
            List.AddRange(new List<Person>() {
            new Person("You", 14, new List<string>() { "11", "12" }),
            new Person("Oleg", 15, new List<string>() { "13", "14" })});
            foreach (var Person in List)
            {
                Console.WriteLine("\n Name: " + Person.Name + " " + "Age: " + Person.Age);
            }
            foreach (var item in List)
            {
                Console.WriteLine("\n {0} have this number:", item.Name);
                foreach (var number in item.PersonNumbers)
                {
                    Console.WriteLine(" {0}", number);
                }
            }
        }
    }
} 

using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        public static List<string> strings;
        static void Main(string[] args)
        {
            strings = new List<string>(100);
            Random random = new Random();
            string trm;

            for (int i = 0; i < 100; i++)
            {
                trm = "";
                for (int j = 0; j < 4; j++)
                {
                    trm += (char)((random.Next() % 26) + 65);
                }

                strings.Add(trm);
            }

            Console.WriteLine("Symbols before transform: {0}", strings.Count);

            while (strings.FindIndex(l => l[0] == 'Z') != -1)
            {
                strings.RemoveAt(strings.FindIndex(l => l[0] == 'Z'));
            }

            Console.WriteLine("Symbols after transform: {0}", strings.Count);

            strings.Sort();
            for (int i = 0; i < strings.Count / 2; i++)
            {
                trm = strings[i];
                strings[i] = strings[strings.Count - 1 - i];
                strings[strings.Count - 1 - i] = trm;
            }

            while (true)
            {
                Console.WriteLine("\nEnter page number: ");
                if (!int.TryParse(Console.ReadLine(), out int Numers))
                    break;
                Numers--;
                Page(Numers);
            }
        Висновок:
            return;
        }
        public static void Page(int Num)
        {
            if (Num * 5 > strings.Count
                || Num < 0)
            {
                Console.Write("Error");
                return;
            }
            for (int i = Num * 5; !(i >= (Num * 5) + 5 || i >= strings.Count); i++)
            {
                Console.Write(strings[i] + "  ");
            }
            return;
        }
    }
}

