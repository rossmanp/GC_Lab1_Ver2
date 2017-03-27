using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pete Rossman
//Grand Circus .NET Lab 1
//March 27, 2017

// This program takes the length, width, and height of a room and
// outputs the area, perimeter, and volume. There is also a prompt
// after the user inputs variables that states if the user wants to
// continue. If not, the program ends.

namespace GC_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //The user inputs the dimensions of the room.
            Console.Write("Enter Length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            //This while loop runs until the user gives a yes (y) or no (n) response to the prompt.
            bool runLoop = true;
            while (runLoop)
            {
                Console.Write("Continue? (y/n): ");
                string entry = Console.ReadLine();
                if (entry.ToLower() == "y")
                {
                    //The area, perimeter, and volume of the room are calculated and output.
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
                    //"Goodbye!" is printed and the program ends.
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();
                    runLoop = false;
                }
                else
                {
                    //If neither y or n is input, the program prints an error message and
                    //asks the user once again for y or n.
                    Console.WriteLine("That was not valid input. Please try again.");
                }
            }
        }
    }
}
