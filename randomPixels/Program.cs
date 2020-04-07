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


                }
                catch (Exception ex) { Console.Write("\n\nError : " + ex.Message + "\n\n"); }
            }
        }
    }
}
