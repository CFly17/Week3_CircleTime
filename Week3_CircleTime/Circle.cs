﻿using System;
using System.Collections.Generic;

namespace Week3_CircleTime
{
    class Circle
    {
        //This should proceed our methods -- it's like a first method
        //We don't need 'radius' in our methods as it's already declared on line 10.

        //PROPERTIES
        public double Radius { get; set; }

        //CONSTRUCTOR FOR VARIABLES
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }


        //METHODS
        public double CalculateCircumference()
        {
            double circ = 2 * Radius * Math.PI;
            double circRounded = Math.Round(circ, 2);
            //rounding of answer -- look into Math. class
            Console.WriteLine($"The circumference of your circle is {circRounded}.");
            return circ;
        }
        public double CalculateArea()
        {
            double area = (Math.PI) * Math.Pow(Radius, 2);
            double areaRounded = Math.Round(area, 2);
            Console.WriteLine($"The area of your circle is {areaRounded}.");
            return area;
        }
        //Added parameter for function 'Continue()'. This parameter awaits data in Program.cs. 
        public bool Continue(List<Circle> Circles)
        {
            bool userContinue = true;
            while (userContinue == true)
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to try another radius? y/n");
                string continueAnswer = Console.ReadLine().ToLower();
                if (continueAnswer == "y")
                {
                    return true;
                }
                else if (continueAnswer == "n")
                {
                    Console.WriteLine("Fine. Go and play with squares.");
                    Console.WriteLine($"You made {Circles.Count} circles!");
                    //for (int i = 0; i < Circles.Count; i++)
                    //{
                    //    Console.WriteLine(Circles[i]);
                    //}
                    return false;
                }
                else
                {
                    Console.WriteLine("Sorry, that wasn't 'y' or 'n'. Try again:");
                    continue;
                }
            }
            return false;
        }
        //public override string ToString()
        //{
        //    string allCirclesPrinted = $"Here is a list of your circles:";
        //    allCirclesPrinted += $"Radius: {Radius} \nCircumference:  \nArea: ";
        //    return allCirclesPrinted;
        //}

    }
}