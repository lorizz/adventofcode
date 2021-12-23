using System;
using System.IO;

namespace ConsolePlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"E:/Programming/C#/Console/AdventOfCode/ex3.txt");

            int[] gammaRate = new int[lines[0].Length], epsilonRate = new int[lines[0].Length];
            int threshold = lines.Length / 2;
            for (int i = 0; i < lines[0].Length; i++)
            {
                int totalOneBits = 0;
                foreach (string line in lines)
                {
                    char[] chars = line.ToCharArray();
                    if (chars[i] == '1') totalOneBits++;
                }
                if (totalOneBits > threshold)
                {
                    gammaRate[i] = 1;
                    epsilonRate[i] = 0;
                }
                else
                {
                    gammaRate[i] = 0;
                    epsilonRate[i] = 1;
                }
            }
            int gr = Convert.ToInt32(string.Join("", gammaRate), 2);
            int er = Convert.ToInt32(string.Join("", epsilonRate), 2);
            Console.WriteLine(gr * er);
        }
    }
}
