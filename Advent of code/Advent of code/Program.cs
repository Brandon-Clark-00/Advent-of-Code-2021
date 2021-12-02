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
            int horizontal = 0, depth = 0, d2 = 0, aim = 0, total = 0;
            foreach (var i in input)
            {
                string[] line = i.Split(' ');
                int x = Int32.Parse(line[1]);
                switch (line[0])
                {
                    case "forward":
                        horizontal += x;
                        d2 += aim * x;
                        break;
                    case "up":
                        depth -= x;
                        aim -= x;
                        break;
                    case "down":
                        depth += x;
                        aim += x;
                        break;
                    default:
                        break;
                }
            }
            total = horizontal * depth;

            Console.WriteLine("Part 1:\nHorizontal pos: " + horizontal + "\nDepth pos: " + depth + "\nTotal: " + total + "\n------------------");

            total = horizontal * d2;

            Console.WriteLine("Part 2:\nHorizontal Pos " + horizontal + "\nDepth pos: " + d2 + "\nAim: " + aim + "\nTotal: " + total);
           


           

        }
    }
}
