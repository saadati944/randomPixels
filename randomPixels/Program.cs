﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomPixels
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int width = 0;
                    do
                    {
                        Console.Write("Enter width : ");
                    } while (!int.TryParse(Console.ReadLine(), out width) || width == 0);
                    Console.WriteLine("width is " + width);

                    int height = 0;
                    do
                    {
                        Console.Write("Enter height : ");
                    } while (!int.TryParse(Console.ReadLine(), out height) || height == 0);
                    Console.WriteLine("height is " + height);

                    int r_start = 0;
                    do
                    {
                        Console.Write("Enter RED start value (from 0 to 254) : ");
                    } while (!int.TryParse(Console.ReadLine(), out r_start) || r_start < 0 || r_start > 254);
                    Console.WriteLine("r_start is " + r_start);

                    int r_end = 0;
                    do
                    {
                        Console.Write("Enter RED end value (from 1 to 255) : ");
                    } while (!int.TryParse(Console.ReadLine(), out r_end) || r_end < 1 || r_end > 255);
                    Console.WriteLine("r_end is " + r_end);

                    int g_start = 0;
                    do
                    {
                        Console.Write("Enter GREEN start value (from 0 to 254) : ");
                    } while (!int.TryParse(Console.ReadLine(), out g_start) || g_start < 0 || g_start > 254);
                    Console.WriteLine("g_start is " + g_start);

                    int g_end = 0;
                    do
                    {
                        Console.Write("Enter GREEN end value (from 1 to 255) : ");
                    } while (!int.TryParse(Console.ReadLine(), out g_end) || g_end < 1 || g_end > 255);
                    Console.WriteLine("g_end is " + g_end);

                    int b_start = 0;
                    do
                    {
                        Console.Write("Enter BLUE start value (from 0 to 254) : ");
                    } while (!int.TryParse(Console.ReadLine(), out b_start) || b_start < 0 || b_start > 254);
                    Console.WriteLine("b_start is " + b_start);

                    int b_end = 0;
                    do
                    {
                        Console.Write("Enter BLUE end value (from 1 to 255) : ");
                    } while (!int.TryParse(Console.ReadLine(), out b_end) || b_end < 1 || b_end > 255);
                    Console.WriteLine("b_end is " + b_end);

                    string path = "";
                    do
                    {
                        Console.Write("enter a path to save files : ");
                        path = Console.ReadLine();
                    } while (!System.IO.Directory.Exists(path) || path.EndsWith("\\") || path.EndsWith("/") || path.Length < 3);

                    int count = 0;
                    do
                    {
                        Console.Write("Enter count (more than 0) : ");
                    } while (!int.TryParse(Console.ReadLine(), out count) || count < 1);
                    Console.WriteLine("count is " + count);
                }
                catch (Exception ex) { Console.Write("\n\nError : " + ex.Message + "\n\n"); }
            }
        }
    }
}
