using System;
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


                }
                catch (Exception ex) { Console.Write("\n\nError : " + ex.Message + "\n\n"); }
            }
        }
    }
}
