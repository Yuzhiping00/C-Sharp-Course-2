/*
Class: Triangle.cs
Author: Zhiping Yu
Student# : 000822513
Date:   October 10, 2020
Purpose: This class is one subclass of Shape and it overrides the most methods of superclass. Since it
         is a concrete class, it can be inheritted by other classes and used to creat objects in other
         classes.
         
I, Zhiping Yu, 000822513 certify that this material is my original work.  
No other person's work has been used without due acknowledgement.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Triangle : Shape
    {
        public double Base { get; set; } // the base of a triangle
        public double Height { get; set; } // the height of a triangle
        /// <summary>
        /// Constructor  initilize the type of the Triangle object
        /// </summary>
        /// <param name="type">string the type value of Triangle</param>
        public Triangle(string type) : base()
        {
            Type = type;
        }
        /// <summary>
        /// Calculate the area of a triangle based on the formula
        /// </summary>
        /// <returns>double the area of a triangle</returns>
        public override double CalculateArea()
        {
            return Base * Height / 2;
        }
        /// <summary>
        /// Triangle has no volume, so it returns 0
        /// </summary>
        /// <returns>0</returns>

        public override double CalculateVolume()
        {
            return 0;

        }
        /// <summary>
        /// Set the values of base and height of a triangle based on user's input
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the base: ");
            string bases = Console.ReadLine();
            Base = double.Parse(bases);
            Console.Write("\nEnter the height: ");
            string height = Console.ReadLine();
            Height = double.Parse(height);
        }
        /// <summary>
        /// Display the triangle's type, area, base and height in a formatted way.
        /// </summary>
        /// <returns>represetation of a triangle</returns>
        public override string ToString()
        {
            return $"{Type,-19} {CalculateArea(),-38:F2}base = {Base,-13:F2} height = {Height,-12:F2}";
        }
    }
}
