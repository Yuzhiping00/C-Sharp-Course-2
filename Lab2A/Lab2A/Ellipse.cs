/*
Class: Ellipse.cs
Author: Zhiping Yu
Student# : 000822513
Date:   October 10, 2020
Purpose: This class is one subclass of Shape and it overrides the methods of superclass. Since it
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
    class Ellipse : Shape
    {
        
        public double Major_Length { get; set; } // the semi_major axes
        public double Minor_Length { get; set; } // the semi_minor axes
        /// <summary>
        /// Constructor initilize the Type property
        /// </summary>
        /// <param name="type">type of shape</param>
        public Ellipse(string type) : base()
        {
            Type = type;
        }
        /// <summary>
        /// Calculate the area of the ellipse.
        /// </summary>
        /// <returns>the area of the ellipse</returns>
        public override double CalculateArea()
        {

            return PI * Major_Length * Minor_Length;
        }
        /// <summary>
        /// Calculate the volume of ellipse. Since ellipse has no volume value, it returns 0 .
        /// </summary>
        /// <returns>0</returns>
        public override double CalculateVolume()
        {
            return 0;
        }
        /// <summary>
        /// Set the value of properties including the semi_major axis length and semi_minor axis length
        /// based on user's input
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the semi-major axis length: ");
            string major = Console.ReadLine();
            Major_Length = double.Parse(major);// convert string to double
            Console.Write("\nEnter the semi-minor axis length: ");
            string minor = Console.ReadLine();
            Minor_Length = double.Parse(minor);
            
        }
        /// <summary>
        /// Display the ellipse's type, area, and semi_major and semi_minor axes values  in a formatted way.
        /// </summary>
        /// <returns>string, the representation of ellipse</returns>
        public override string ToString()
        {
        return $"{Type,-20}{CalculateArea(),-38:F2}major = {Major_Length,-12:F2} minor = {Minor_Length,-12:F2}";
    }

    }
}
