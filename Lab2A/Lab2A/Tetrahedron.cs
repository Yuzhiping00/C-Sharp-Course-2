/*
Class: Tetrahedron.cs
Author: Zhiping Yu
Student# : 000822513
Date:   October 10, 2020
Purpose: This class is one subclass of Triangle and it overrides the methods of superclass. Since it
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
    class Tetrahedron : Triangle
    {
        public double Length { get; set; } // the length of a tetrahedron
        /// <summary>
        /// Constructor   initialize the type of a tetrahedron
        /// </summary>
        /// <param name="type">string   the type of a tetrahedron</param>
        public Tetrahedron(string type) : base(type)
        {
           
        }
        /// <summary>
        /// Overrides the method and Calculates the surface area of a tetrahedron based on the formula
        /// </summary>
        /// <returns>double   the surface area of a tetrahedron</returns>
        public override double CalculateArea()
        {     
            // bothe base and height of a tetrahedron are equal to the length of it
            Base = Length;
            Height = Length;
            return Math.Sqrt(3) * base.CalculateArea()*2;
        }
        /// <summary>
        /// Overrides the method and calculate the volume of a tetrahedron based on the formula
        /// </summary>
        /// <returns>double   the volume of a tetrahedron</returns>
        public override double CalculateVolume()
        {
            return Math.Sqrt(2) * base.CalculateArea() * 2 * Length / 12;
        }
        /// <summary>
        /// Overrides the method and sets the length of a tetrahedron based on the user's input
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the length: ");
            string length = Console.ReadLine();
            Length = double.Parse(length);
        }
        /// <summary>
        /// Display a tetrahedron's type, area, volume and length in a formatted way
        /// </summary>
        /// <returns>strig   the representation of a tetrahedron</returns>
        public override string ToString()
        {
            return $"{ Type,-20}{CalculateArea(),-20:F2}{CalculateVolume(),-18:F2}" +
               $"length = {Length,-12:F2}";
        }
    }
}
