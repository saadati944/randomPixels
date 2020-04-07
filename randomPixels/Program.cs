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

                }
                catch (Exception ex) { Console.Write("\n\nError : " + ex.Message + "\n\n"); }
            }
        }
    }
}
