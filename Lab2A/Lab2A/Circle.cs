/*
Class: Circle.cs
Author: Zhiping Yu
Student# : 000822513
Date:   October 10, 2020
Purpose: This class is one subclass of Ellipse and it overrides the methods of superclass. Since it
         is a concrete class, it can be inheritted by other classes and used to creat objects in other
         classes.
         
I, Zhiping Yu, 000822513 certify that this material is my original work.  
No other person's work has been used without due acknowledgement.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Circle : Ellipse
    {
        public double Radius { get; set; } // the radius of a circle
        /// <summary>
        /// Constructor    initialize the type of a circle
        /// </summary>
        /// <param name="type">string   the type of a circle</param>
        public Circle(string type) : base(type)
        {
        }
        /// <summary>
        /// Overrides the CalculateArea method and Calculate the area of a circle based on mathematic formula
        /// </summary>
        /// <returns>double   the area of a circle</returns>
        public override double CalculateArea()
        {
            // a circle's semi_major axis = semi_minor axis. Both of them are equal to the radius
            Major_Length = Radius; 
            Minor_Length = Radius;
            return base.CalculateArea();
        }
        /// <summary>
        /// Overrides the CalculateVolume method and returns 0
        /// </summary>
        /// <returns>0</returns>
        public override double CalculateVolume()
        {
            return base.CalculateVolume();
        }
        /// <summary>
        /// Set the radius of a circle based on the user's input
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the radius: ");
            string radius = Console.ReadLine();
            Radius = double.Parse(radius);
        }
        /// <summary>
        /// Display the circle's type, area and radius in a formatted way
        /// </summary>
        /// <returns>string   the representation of a circle</returns>
        public override string ToString()
        {
            return $"{Type,-19} {CalculateArea(),-36:F2}  radius = {Radius:F2}";
        }


    }
}
