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
            bool runLoop = true;
            List<double> dimensions = new List<double>();
            while (runLoop)
            {
                Console.Write("Continue or print out rooms entered so far? (y/n/print): ");
                string entry = Console.ReadLine();
                if (entry.ToLower() == "y")
                {
                double length = 0;
                double width = 0;
                double height = 0;
                
                //The user inputs the dimensions of the room.
                Console.Write("Enter Length: ");
                try
                {
                    length = Convert.ToDouble(Console.ReadLine());                     
                }
                catch (FormatException)
                {
                    Console.WriteLine("You did not enter a number! Setting length equal to 5.");
                    length = 5;
                }

                Console.Write("Enter Width: ");
                try
                {
                    width = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You did not enter a number! Setting width equal to 5.");
                    width = 5;
                }
                Console.Write("Enter Height: ");
                try
                {
                    height = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You did not enter a number! Setting height equal to 5.");
                    height = 5;
                }

            //This while loop runs until the user gives a yes (y) or no (n) response to the prompt.
            
            
                
                    //The area, perimeter, and volume of the room are calculated and output.
                    double area = Area(length, width);
                    double perimeter = Perimeter(length, width);
                    double volume = Volume(length, width, height);

                    Console.WriteLine("Area: " + area);
                    dimensions.Add(area);
                    Console.WriteLine("Perimeter: " + perimeter);
                    dimensions.Add(perimeter);
                    Console.WriteLine("Volume: " + volume);
                    dimensions.Add(volume);
                    Console.ReadLine();
                    
                }
                else if (entry.ToLower() == "n")
                {
                    //"Goodbye!" is printed and the program ends.
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();
                    runLoop = false;
                }
                else if (entry.ToLower() == "print")
                {
                    Console.WriteLine("Rooms entered so far:");
                    for (int i = 0; i < dimensions.Count; i++)
                    {
                        Console.WriteLine("\nArea: " + dimensions[i]);
                        i++;
                        Console.WriteLine("Perimeter: " + dimensions[i]);
                        i++;
                        Console.WriteLine("Volume: " + dimensions[i]);
                    }
                }
                else
                {
                    //If neither y or n is input, the program prints an error message and
                    //asks the user once again for y or n.
                    Console.WriteLine("That was not valid input. Please try again.");
                }
            }
        }
        public static double Perimeter(double len, double wid) => (2 * len) + (2 * wid);

        public static double Area(double len, double wid) => len * wid;

        public static double Volume(double len, double wid, double hei) => len * wid * hei;
    }
}
