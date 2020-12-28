using System;
using System.IO;

namespace CSLab8Task1
{
    class IOsystemDirectory
    {
        public static void Main()
        {
            int numeratingOfDir = 0;
            string dirName = @"D:\EpamCSLabs";
            Console.WriteLine("Subdirectories:\n");
            DirectoryInfo dir = new DirectoryInfo(dirName);
            DirectoryInfo[] allDirs = dir.GetDirectories();
            foreach (var values in allDirs)
            {
                numeratingOfDir++;
                Console.WriteLine($"{numeratingOfDir}. {values}");
                DirectoryInfo dirContains = new DirectoryInfo(values.FullName);
                DirectoryInfo[] directoryContain = dirContains.GetDirectories();
                int numeratingOfContain = 0;
                foreach (var item in directoryContain)
                {
                    numeratingOfContain++;
                    Console.WriteLine($"  {numeratingOfContain}. {item.FullName}");
                }
            }

            Console.WriteLine("\n\nFiles:");
            FileInfo[] files = dir.GetFiles();
            foreach (var value in files)
            {
                Console.WriteLine(value);
            }

        }
    }
}

using System;
using System.IO;

public class IOsystemDirectory
{
    public static void Main()
    {
        Console.WriteLine("Enter the name of file you want to find: ");
        string enter = Console.ReadLine();
        string dirName = @"D:\EpamCSLabs";
        DirectoryInfo dir = new DirectoryInfo(dirName);
        string[] allFoundFiles = Directory.GetFiles(dirName, $"*{enter}*.txt", SearchOption.AllDirectories);
        if (allFoundFiles.Length > 0)
        {
            foreach (string file in allFoundFiles)
            {
                Console.WriteLine(file);
            }
        }
        else
        {
            Console.WriteLine("Can not find file");
        }
    }
}

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

    [Serializable]
public class PC
{
    public string Name;
    public string Motherboard;
    public string Processor;
    public string RAM;
    public string Video_card;
    public string HDD;
    public string SSD;

    public PC() { }
}

public class Task3_Binary
{
    public static void Main()
    {
        PC pc = new PC();
        pc.Name = "ASRock";
        pc.Motherboard = "AMD A320";
        pc.Processor = "AMD Ryzen 3 1200";
        pc.RAM = "8Gb";
        pc.Video_card = "GeForce GTX 750 Ti";
        pc.HDD = "None";
        pc.SSD = "480GB";
        Console.WriteLine("Object created");

        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream fs = new FileStream("pc.binary", FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, pc);

            Console.WriteLine("Object serialized");
        }
        using (FileStream fs = new FileStream("pc.binary", FileMode.OpenOrCreate))
        {
            PC newPC = (PC)formatter.Deserialize(fs);

            Console.WriteLine("Object deserialized");
            Console.WriteLine($"\nPC Name: {newPC.Name} \nMotherboard: {newPC.Motherboard} \nProcessor: {newPC.Processor} \nRAM: {newPC.RAM} \nVideo Card: {newPC.Video_card} \nHDD: {newPC.HDD} \nSSD: {newPC.SSD}");
        }
    }
}

using System;
using System.IO;
using System.Xml.Serialization;

    public class PC
{
    public string Name;
    public string Motherboard;
    public string Processor;
    public string RAM;
    public string Video_card;
    public string HDD;
    public string SSD;
    public PC() { }
}
public class Task3_XML
{
    public static void Main()
    {
        PC pc = new PC();
        pc.Name = "ASRock";
        pc.Motherboard = "AMD A320";
        pc.Processor = "AMD Ryzen 3 1200";
        pc.RAM = "8Gb";
        pc.Video_card = "GeForce GTX 750 Ti";
        pc.HDD = "1Tb";
        pc.SSD = "480GB";
        Console.WriteLine("Object created");

        XmlSerializer formatter = new XmlSerializer(typeof(PC));
        using (FileStream fs = new FileStream("pc.xml", FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, pc);

            Console.WriteLine("Object serialized");
        }
        using (FileStream fs = new FileStream("pc.xml", FileMode.OpenOrCreate))
        {
            PC newPC = (PC)formatter.Deserialize(fs);

            Console.WriteLine("Object deserialized");
            Console.WriteLine($"\nPC Name: {newPC.Name} \nMotherboard: {newPC.Motherboard} \nProcessor: {newPC.Processor} \nRAM: {newPC.RAM} \nVideo Card: {newPC.Video_card} \nHDD: {newPC.HDD} \nSSD: {newPC.SSD}");
        }
    }
}