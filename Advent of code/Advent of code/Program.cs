using System;
using System.IO;
using System.Collections.Generic;

namespace Advent_of_code
{
    class Program
    {

        /*string[] input;*/
        /*string output;*/
        

        static void Main(string[] args)
        {

            Console.WriteLine("Init");
            day1();
            Console.WriteLine("Complete");

        }

        static void day1()
        {
            int counter = 0;
            string[] input = File.ReadAllLines(@"C:\Users\Brandon\Documents\uni\Advent-of-Code-2021\Advent of code\Advent of code\Input.txt");
            for (int i = 1; i < input.Length; i++)
            {
                if (Int32.Parse(input[i]) > Int32.Parse(input[i - 1]))
                {
                    counter++;
                }
            }
            Console.WriteLine("Result for part 1:" + counter);
            List<int> measurement = new List<int>();
            for (int i = 2; i < input.Length; i++)
            {
                measurement.Add(Int32.Parse(input[i]) + Int32.Parse(input[i - 1]) + Int32.Parse(input[i - 2]));
            }
            counter = 0;
            for (int i = 1; i < measurement.Count; i++)
            {
                if (measurement[i] > measurement[i - 1])
                {
                    counter++;
                }
            }

            Console.WriteLine("Result for part 2:" + counter);
        }
    }
}
