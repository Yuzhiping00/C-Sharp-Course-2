/*
Class: Rectangle.cs
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
    class Rectangle:Shape
    {
        public double Length { get; set; } // the length of a rectangle
        public double Width { get; set; } // the width of a rectangle
        /// <summary>
        /// Constructor initilize the type of a Rectangle
        /// </summary>
        /// <param name="type">string   the type of a Rectangle</param>
        public Rectangle(string type) : base()
        {
            Type = type;
        }
        /// <summary>
        /// Calculate the area of a rectangle
        /// </summary>
        /// <returns>the area of a rectangle</returns>
        public override double CalculateArea()
        {
            return Length * Width;
        }
        /// <summary>
        /// Rectangle has no volume, so it returns 0
        /// </summary>
        /// <returns>0</returns>
        public override double CalculateVolume()
        {
            return 0;
        }
        /// <summary>
        /// Set the values for the length and width of a rectangle based on the user's input
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the length: ");
            string length = Console.ReadLine();
            Length = double.Parse(length);
            Console.Write("\nEnter the width: ");
            string width = Console.ReadLine();
            Width = double.Parse(width);
            
    }
        /// <summary>
        /// Display a rectangle's type, area, length and width in a formatted way
        /// </summary>
        /// <returns>string    representation of a rectangle </returns>
        public override string ToString()
        {
            return $"{ Type,-20}{CalculateArea(),-38:F2}length = {Length,-12:F2}width = {Width,-12:F2}";
        }

    }
}
