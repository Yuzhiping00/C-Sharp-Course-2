/*
Class: Box.cs
Author: Zhiping Yu
Student# : 000822513
Date:   October 10, 2020
Purpose: This class is one subclass of Rectangle and it overrides the methods of superclass. Since it
         is a concrete class, it can be inheritted by other classes and used to creat objects in other
         classes.
         
I, Zhiping Yu, 000822513 certify that this material is my original work.  
No other person's work has been used without due acknowledgement.

*/

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Box : Rectangle
    {
        public double Height { get; set; } // the height of a box
        /// <summary>
        /// Constructor  initialize the type of a Box
        /// </summary>
        /// <param name="type">string the type of the Box</param>
        public Box(string type) : base(type)
        { 
           
        }
        /// <summary>
        /// Calculate the surface area of a box instance based on the formula
        /// </summary>
        /// <returns>double   the area of a box object</returns>
        public override double CalculateArea()
        {
            return 2 * base.CalculateArea() + 2 * Length * Height + 2 * Width * Height;
        }
        /// <summary>
        /// Calculate the volume of a box based on the formula
        /// </summary>
        /// <returns>double  the volume of a box</returns>
        public override double CalculateVolume()
        {
           
            return base.CalculateArea() * Height;
        }
        /// <summary>
        /// Set the length, width and height of a box based on the user's input
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the length: ");
            string length = Console.ReadLine();
            Length = double.Parse(length);
            Console.Write("\nEnter the width: ");
            string width = Console.ReadLine();
            Width = double.Parse(width);
            Console.Write("\nEnter the height: ");
            string height = Console.ReadLine();
            Height = double.Parse(height);
        }
        /// <summary>
        /// Display a box's type, area, volume, length, width and height in a formatted way
        /// </summary>
        /// <returns>string  the representation of a box</returns>
        public override string ToString()
        {
            return $"{ Type,-20}{CalculateArea(),-20:F2}{CalculateVolume(),-18:F2}" +
                $"length = {Length,-12:F2}width = {Width,-12:F2}height = {Height:F2}";
        }
           
    }
        }
