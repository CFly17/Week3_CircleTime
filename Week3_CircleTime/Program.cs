using System;
using System.Collections.Generic;

namespace Week3_CircleTime
{
    class Program
    {
        public static List<Circle> Circles { get; set; } = new List<Circle>();
        static void Main(string[] args)
        {
            //prompt user for radius
            //prompt to continue
            //print goodbye
            //print amount of circles created during game
            //Try putting in the method:
            //numberOfInvokes += 1;

            bool goOn = true;

            Console.WriteLine("Welcome to the Circle Game, where you feed us radii and we feed you facts!");
            Console.WriteLine();

            while (goOn == true)
            {
                Console.WriteLine("Please enter a radius here:");
                double userRadius = double.Parse(Console.ReadLine());

                Circle c = new Circle(userRadius);

                c.CalculateCircumference();
                c.CalculateArea();
                Circles.Add(c);
               
                goOn = c.Continue(Circles);
            }
        }
    }
}
