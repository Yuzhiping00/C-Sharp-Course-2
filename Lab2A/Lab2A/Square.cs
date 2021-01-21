/*
Class: Square.cs
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Square : Rectangle
    {
        /// <summary>
        /// Constructor initialize the type of a Square
        /// </summary>
        /// <param name="type">the type of a square</param>
        public Square(string type) : base(type)
        {
        }
        /// <summary>
        /// Calculate the area of a square
        /// </summary>
        /// <returns>double  the area of a square</returns>
        public override double CalculateArea()
        {
            Width = Length; // a square's width is equal to its length
            return base.CalculateArea();
        }
        /// <summary>
        /// Square has no volume, so its volume is equal to 0 too
        /// </summary>
        /// <returns>0</returns>
        public override double CalculateVolume()
        {
            return base.CalculateVolume();
        }
        /// <summary>
        /// Set the length of a square based on the user's input
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the length: ");
            string length = Console.ReadLine();
            Length = double.Parse(length);
            
        }
        /// <summary>
        /// Display a square's type, area and length values in a formatted way
        /// </summary>
        /// <returns>string the reprentation of a square</returns>
        public override string ToString()
        {
           
            return $"{ Type,-20}{CalculateArea(),-38:F2}length = {Length,-18:F2}";
        }
    }
}
