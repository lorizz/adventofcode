using System;
using System.IO;

namespace ConsolePlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"E:/Programming/C#/Console/AdventOfCode/ex2.txt");
            int horizontal = 0;
            int depth = 0;
            foreach (string line in lines)
            {
                string[] split = line.Split(' ');
                string direction = split[0];
                int amount = int.Parse(split[1]);
                switch (direction)
                {
                    case "forward":
                        horizontal += amount;
                        break;
                    case "down":
                        depth += amount;
                        break;
                    case "up":
                        depth -= amount;
                        break;
                }
            }
            Console.WriteLine(horizontal * depth);
        }
    }
}
