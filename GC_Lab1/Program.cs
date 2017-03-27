using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            bool runLoop = true;
            while (runLoop)
            {
                Console.WriteLine("Continue? (y/n)");
                string entry = Console.ReadLine();
                if (entry.ToLower() == "y")
                {
                    double area = length * width;
                    double perimeter = (2 * length) + (2 * width);
                    double volume = area * height;

                    Console.WriteLine("Area: " + area);
                    Console.WriteLine("Perimeter: " + perimeter);
                    Console.WriteLine("Volume: " + volume);
                    Console.ReadLine();
                    runLoop = false;
                }
                else if (entry.ToLower() == "n")
                {
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();
                    runLoop = false;
                }
                else
                {
                    Console.WriteLine("That was not valid input. Please try again.");
                }
            }
        }
    }
}
