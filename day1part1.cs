using System;
using System.IO;

namespace ConsolePlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"E:/Programming/C#/Console/AdventOfCode/ex1.txt");

            int oldValue = int.Parse(lines[0]);
            int counter = 0;
            foreach (string line in lines)
            {
                int value = int.Parse(line);
                if (value > oldValue)
                {
                    counter++;
                }
                oldValue = value;
            }
            Console.WriteLine(counter);
        }
    }
}
