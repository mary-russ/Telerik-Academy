using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._3DSlice
{
    class Slice3D
    {
        static void Main(string[] args)
        {
           /* 4 2 3 - 4 - width, 2 - height,3 - depth 
            3 4 1 9 | 1 2 3 8 | 1 5 6 7
            1 2 1 9 | 5 1 3 9 | 5 3 3 8 */
            string sizeStr = Console.ReadLine();//input is on one row
            string[] size = sizeStr.Split(' ');
            int width = int.Parse(size[0]);
            int height = int.Parse(size[1]);
            int depth = int.Parse(size[2]);
            int[,,] cube = new int[width, height, depth];
            for (int w = 0; w < width; w++)
            {
              for (int h = 0; h < height; h++)
                {
                    string line = Console.ReadLine();//reading height - 2, then -> Split
                    string[] tokens = line.Split('|');//get depth => for for depth
                    for (int d = 0; d < depth; d++)
                    {
                        string[] numbers = tokens[d].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        {
                            int value = int.Parse(numbers[w]);
                            cube[w, h, d] = value;
                        }
                    }
                }
            }
            for (int w = 0; w < width; w++)
            {
                for (int h = 0; h < height; h++)
                {
                    for (int d = 0; d < depth; d++)
                    {
                        Console.Write(cube[w, h, d]);
                    }
                    Console.Write(' ');
                }
                Console.WriteLine();
            }

            long totalSum = 0;
            for (int w = 0; w < width; w++)
            {
                for (int h = 0; h < height; h++)
                {
                    for (int d = 0; d < depth; d++)
                    {
                        totalSum += cube[w, h, d];//total sum
                    }
                }
            }

            int count = 0;//total number of splits of the cuboid into equal-sum sub-cuboids.
            long sum = 0;
            for (int w = 0; w < width-1; w++)// -1 - slices
            {
                for (int h = 0; h < height; h++)
                {
                    for (int d = 0; d < depth; d++)
                    {
                        sum += cube[w, h, d];
                    }
                }
                if (sum + sum == totalSum)
                {
                    count++;
                }
            }
            sum = 0;
            for (int h = 0; h < height-1; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    for (int d = 0; d < depth; d++)
                    {
                        sum += cube[w, h, d];
                    }
                }
                if (sum + sum == totalSum)
                {
                    count++;
                }
            }
            sum = 0;
            for (int d = 0; d < depth-1; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    for (int h = 0; h < height; h++)
                    {
                        sum += cube[w, h, d];
                    }
                }
                if (sum + sum == totalSum)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
