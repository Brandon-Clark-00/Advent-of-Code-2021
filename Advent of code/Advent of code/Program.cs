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
            day2();
            Console.WriteLine("Complete");

        }

        static void day1()
        {
            int counter = 0;
            string[] input = File.ReadAllLines(@"../../../Inputs/1.txt");
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
        

        static void day2()
        {
            string[] input = File.ReadAllLines(@"../../../Inputs/2.txt");
            int horizontal = 0, depth = 0, aim = 0, total = 0;
            foreach (var i in input)
            {
                string[] line = i.Split(' ');
                switch (line[0])
                {
                    case "forward":
                        horizontal += Int32.Parse(line[1]);
                        break;
                    case "up":
                        depth -= Int32.Parse(line[1]);
                        break;
                    case "down":
                        depth += Int32.Parse(line[1]);
                        break;
                    default:
                        break;
                }
            }
            total = horizontal * depth;

            Console.WriteLine("Part 1:");
            Console.WriteLine("Horizontal pos: " + horizontal);
            Console.WriteLine("Depth pos: " + depth);
            Console.WriteLine("Total: " + total);
            Console.WriteLine("-------------------");

            horizontal = 0;  depth = 0; aim = 0; total = 0;

            foreach (var i in input)
            {
                string[] line = i.Split(' ');
                switch (line[0])
                {
                    case "forward":
                        horizontal += Int32.Parse(line[1]);
                        depth += aim * Int32.Parse(line[1]);
                        break;
                    case "up":
                        aim -= Int32.Parse(line[1]);
                        break;
                    case "down":
                        aim += Int32.Parse(line[1]);
                        break;
                    default:
                        break;
                }
            }
            total = horizontal * depth;
            Console.WriteLine("Part 2:");
            Console.WriteLine("Horizontal pos: " + horizontal);
            Console.WriteLine("Depth pos: " + depth);
            Console.WriteLine("Aim: " + aim);
            Console.WriteLine("Total: " + total);
            Console.WriteLine("-------------------");

        }
    }
}
