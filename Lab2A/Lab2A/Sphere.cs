/*
Class: Sphere.cs
Author: Zhiping Yu
Student# : 000822513
Date:   October 10, 2020
Purpose: This class is one subclass of Cylinder and it overrides the methods of superclass. Since it
         is a concrete class, it can be inheritted by other classes and used to creat objects in other
         classes.
         
I, Zhiping Yu, 000822513 certify that this material is my original work.  
No other person's work has been used without due acknowledgement.

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Sphere : Cylinder
    { 
        /// <summary>
        /// Constructor   initialize the type of a sphere
        /// </summary>
        /// <param name="type">string   the type of a sphere</param>
        public Sphere(string type) : base(type)
        {
            
        }
        /// <summary>
        /// Overrides the method and calculate the surface area of a sphere based on the mathematic formula
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            Height = Radius; // the sphere's height is equal to the radius of it
            return  base.CalculateArea();
        }
        /// <summary>
        /// Overrides the method and calculate the volume of a sphere based on the mathematic formula
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {
           
            return Radius*base.CalculateArea() / 3;
        }
        /// <summary>
        /// Set the raidus of a sphere based on the user's input
        /// </summary>
        public override void SetData()
        {
            Console.Write("\nEnter the radius: ");
            string radius = Console.ReadLine();
            Radius = double.Parse(radius);
        }
        /// <summary>
        /// Display the type, area, voulume and raidus of a sphere
        /// </summary>
        /// <returns>string   the representation of a sphere</returns>
        public override string ToString()
        {
            return $"{ Type,-20}{CalculateArea(),-20:F2}{CalculateVolume(),-18:F2}" +
               $"radius = {Radius,-12:F2}";
        }

    }
}
