/*
Class: Cube.cs
Author: Zhiping Yu
Student# : 000822513
Date:   October 10, 2020
Purpose: This class is one subclass of Box and it overrides the methods of superclass. Since it
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
    class Cube : Box
    {
        /// <summary>
        /// Constructor   initialize the type of a cube
        /// </summary>
        /// <param name="type">string   the type of a cube</param>
        public Cube(string type) : base(type)
        {

        }
        /// <summary>
        /// Calculate the surface area of a cube based on the formula
        /// </summary>
        /// <returns>double   the surface area of a cube object</returns>
        public override double CalculateArea()
        {

            return 6 * Length * Length;
        }
        /// <summary>
        /// Calculate the volume of a cube based on the formula
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {
            Height = Length; // cube's height is equal to the length
            Width = Length; // cube's width is equal to the length
            return base.CalculateVolume();
        }
        /// <summary>
        /// Set a cube's length based on the user's input
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the length: ");
            string length = Console.ReadLine();
            Length = double.Parse(length);
        }
        /// <summary>
        /// Display the information of a cube including type, area, volume and length in a formatted way
        /// </summary>
        /// <returns>string   the representation of a cube</returns>
        public override string ToString()
        {
            return $"{ Type,-20}{CalculateArea(),-20:F2}{CalculateVolume(),-18:F2}" +
                 $"length = {Length,-12:F2}";
        }



    }
}
