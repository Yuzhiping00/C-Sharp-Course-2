/*
Class: Cylinder.cs
Author: Zhiping Yu
Student# : 000822513
Date:   October 10, 2020
Purpose: This class is one subclass of Circle and it overrides the methods of superclass. Since it
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
    class Cylinder : Circle
    {
        public double Height { get; set; } // the height of a cylinder
        /// <summary>
        /// Constructor    initialize the type of a cylinder
        /// </summary>
        /// <param name="type">string   the type of a cylinder</param>
        public Cylinder(string type) : base(type)
        {
            
        }
        /// <summary>
        /// Overrides the CalculateArea method and calculate the surface area of a cylinder based on mathematic formula
        /// </summary>
        /// <returns>double  the area of a cylinder</returns>
        public override double CalculateArea()
        {
            return 2 * base.CalculateArea() + 2 * PI*Radius * Height;
        }
        /// <summary>
        /// Overrides the CalculateVolume method and calculate the volume of a cylinder based on the
        /// mathematic  formula
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {
            return base.CalculateArea() * Height;
        }
        /// <summary>
        /// Overrides the SetData method, which set the radius and height of a cylinder based on the user's input
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the radius: ");
            string radius = Console.ReadLine();
            Radius = double.Parse(radius);
            Console.Write("\nEnter the height: ");
            string height = Console.ReadLine();
            Height = double.Parse(height);
        }
        /// <summary>
        /// Display a cylinder's type, area, volume, radius and height in a formatted way
        /// </summary>
        /// <returns>string   the representation of a cylinder</returns>
        public override string ToString()
        {
            return $"{ Type,-20}{CalculateArea(),-20:F2}{CalculateVolume(),-18:F2}" +
                $"radius = {Radius,-12:F2}height = {Height,-12:F2}";
        }
    }
}

