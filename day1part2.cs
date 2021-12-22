using System;
using System.IO;

namespace ConsolePlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"E:/Programming/C#/Console/AdventOfCode/ex1.txt");

            int oldWindow = int.Parse(lines[0]) + int.Parse(lines[1]) + int.Parse(lines[2]);
            int counter = 0;
            for (int i = 0; i < lines.Length - 2; i++)
            {
                int window = int.Parse(lines[i]) + int.Parse(lines[i + 1]) + int.Parse(lines[i + 2]);
                if (window > oldWindow)
                    counter++;
                oldWindow = window;
            }
            Console.WriteLine(counter);
        }
    }
}
