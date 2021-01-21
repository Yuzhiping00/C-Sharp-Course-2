/*
Class: Program.cs
Author: Zhiping Yu
Student# : 000822513
Date:   October 10, 2020
Purpose: This class is the main class which is to provide menu for user to make choice of 
         producing different shapes and display the shapes related information. 
         In addition, this class handles the invalid input.
         
I, Zhiping Yu, 000822513 certify that this material is my original work.  
No other person's work has been used without due acknowledgement.

*/
using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab2A
{
    
    class Program
    {
        /// <summary>
        /// Main method is to call the ProcessUserInput() and control the whole process
        /// </summary>
        /// <param name="args">Not used</param>
        static void Main(string[] args)
        {
           ProcessUserInput();
        }
        /// <summary>
        /// This method is to create a menu for user to make different choices of shapes.
        /// </summary>
        private static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nZhiping's Geometry Class:\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" A - Rectangle     B - Ellipse      C - Triangle");
            Console.WriteLine(" D - Square        E - Circle       F - Tetrahedron");
            Console.WriteLine(" G - Box           H - Cylinder");
            Console.WriteLine(" I - Cube          J - Sphere\n");
            Console.WriteLine(" 0 -List all shapes and Exit ....\n");  
        }
        /// <summary>
        /// This method is ask user what shapes they want to be added into the list. Based on their 
        /// choices, the program will respond differently.
        /// </summary>
        private static void ProcessUserInput()
        {
            List<Shape> shapes = new List<Shape>(); // Create a new empty list with Shape elements
            DisplayMenu();

            // check if dimension values are valid, if any values cannot be converted into double, producing
            //  error messeage and exit the program.

            try
            {
                while (true) // repeatedly asking user to select shapes, until they enter 0
                {
                    Console.Write($"Enter your choice:      ({Shape.GetCount()} shapes entered so far)");
                    Console.SetCursorPosition(19, 10);
                    string option = Console.ReadLine();
                    if (option.ToLower().Equals("a"))
                    {

                        Select_A(shapes);
                    }
                    else if (option.ToLower().Equals("b"))
                    {

                        Select_B(shapes);
                           
                    }
                    else if (option.ToLower().Equals("c"))
                    {

                        Select_C(shapes);
                        
                    }
                    else if (option.ToLower().Equals("d"))
                    {
                        Select_D(shapes);

                    }
                    else if (option.ToLower().Equals("e"))
                    {
                        Select_E(shapes);

                    }
                    else if (option.ToLower().Equals("f"))
                    {
                        Select_F(shapes);

                    }
                    else if (option.ToLower().Equals("g"))
                    {
                        Select_G(shapes);

                    }
                    else if (option.ToLower().Equals("h"))
                    {
                        Select_H(shapes);

                    }
                    else if (option.ToLower().Equals("i"))
                    {
                        Select_I(shapes);

                    }
                    else if (option.ToLower().Equals("j"))
                    {
                       Select_J(shapes);
                    }
                    else if (option.Equals("0"))
                    {
                        Select_0(shapes);
                        break;
                    }
                    else
                    {
                        Invalid_Selection();

                    }
                    Console.Clear();
                    DisplayMenu();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\nException occurs due to:{ex.Message}\n");
                Console.WriteLine("Please click any key to close.\n");
                Console.ReadKey();

            }
            
        }
        /// <summary>
        /// This method is to show user that their input for selecting shapes is invalid, 
        /// and they can continue to select after pressing any key. 
        /// </summary>
        private static void Invalid_Selection()
        {
            Console.WriteLine("\nThis is not a valid choice, please try again!");
            Console.WriteLine("\nPlease any key to continue... ");
            Console.ReadKey();
        }
        /// <summary>
        /// When user enter 0, if the List<Shape> is empty, only author's name and 0 object
        /// text will be shown. Otherwise, the elements in the list will be print out.
        /// </summary>
        /// <param name="shapes">the type of elements in list is Shape </param>
        private static void Select_0(List<Shape> shapes)
        {
            Console.Clear();
            if (shapes.Count == 0)
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Zhiping's Geometry Class:\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"There are {shapes.Count()} objects:\n");
            }
            else { ShowList(shapes); }
            Console.WriteLine("\nPlease any key to exit... ");
            Console.ReadKey();
        }
        /// <summary>
        /// If user enter j or J, create an object of Sphere and set dimensions for it based on input. if any dimensions
        /// equal or less than 0, user should be given error message and has another chance to continue. 
        /// However, the instance should not be added into the list.
        /// </summary>
        /// <param name="shapes">a list which contains elements that are Shape type</param>
        private static void Select_J(List<Shape> shapes)
        {
            Shape sphere = new Sphere("sphere");
            sphere.SetData();
            Sphere s = (Sphere)sphere;
            if (s.Radius <= 0)
            {
                InvalidDimensions();
            }
            else { shapes.Add(sphere); }
        }
        /// <summary>
        /// If user enter i or I, create an object of Cube and set dimensions for it based on input. if any dimensions
        /// equal or less than 0, user should be given error message and has another chance to continue. 
        /// However, the instance should not be added into the list.
        /// </summary>
        /// <param name="shapes">a list which contains elements that are Shape type</param>

        private static void Select_I(List<Shape> shapes)
        {
            Shape cube = new Cube("cube");

            cube.SetData();
            Cube c = (Cube)cube;
            if (c.Length <= 0)
            {
                InvalidDimensions();
            }
            else { shapes.Add(cube); }
        }
        /// <summary>
        /// If user enter h or H, create an object of Cylinder and set dimensions for it based on input. if any dimensions
        /// equal or less than 0, user should be given error message and has another chance to continue. 
        /// However, the instance should not be added into the list.
        /// </summary>
        /// <param name="shapes">a list which contains elements that are Shape type</param>

        private static void Select_H(List<Shape> shapes)
        {
            Shape cylinder = new Cylinder("cylinder");
            cylinder.SetData();
            Cylinder c = (Cylinder)cylinder;
            if (c.Radius <= 0 || c.Height <= 0)
            {
                InvalidDimensions();
            }
            else { shapes.Add(cylinder); }
        }

        /// <summary>
        /// If user enter g or G, create an object of Box and set dimensions for it based on input. if any dimensions
        /// equal or less than 0, user should be given error message and has another chance to continue. 
        /// However, the instance should not be added into the list.
        /// </summary>
        /// <param name="shapes">a list which contains elements that are Shape type</param>

        private static void Select_G(List<Shape> shapes)
        {
            Shape box = new Box("box");
            box.SetData();
            Box b = (Box)box;
            if (b.Length <= 0 || b.Length <= 0 || b.Width <= 0)
            {
                InvalidDimensions();
            }
            else { shapes.Add(box); }
        }
        /// <summary>
        /// If user enters f or F, create an object of Tetrahedron, set dimensions for it based on input, then add it to the list. 
        /// If any dimensions equal or less than 0, user should be given error message and has another chance to continue. 
        /// However, the instance should not be added into the list.
        /// </summary>
        /// <param name="shapes">a list which contains elements that are Shape type</param>

        private static void Select_F(List<Shape> shapes)
        {
            Shape tetrahedron = new Tetrahedron("tetrahedron");
            tetrahedron.SetData();
            Tetrahedron t = (Tetrahedron)tetrahedron;
            if (t.Length <= 0)
            {
                InvalidDimensions();
            }
            else { shapes.Add(tetrahedron); }
        }

        /// <summary>
        /// If user enters e or E, create an object of Circle, set dimensions for it based on input, then add it to the list. 
        /// If any dimensions equal or less than 0, user should be given error message and has another chance to continue. 
        /// However, the instance should not be added into the list.
        /// </summary>
        /// <param name="shapes">a list which contains elements that are Shape type</param>
        private static void Select_E(List<Shape> shapes)
        {
            Shape circle = new Circle("circle");
            circle.SetData();
            Circle c = (Circle)circle;
            if (c.Radius <= 0)
            {

                InvalidDimensions();
            }
            else { shapes.Add(circle); }
        }

        /// <summary>
        /// If user enters d or D, create an object of Square, set dimensions for it based on input, then add it to the list. 
        /// If any dimensions equal or less than 0, user should be given error message and has another chance to continue. 
        /// However, the instance should not be added into the list.
        /// </summary>
        /// <param name="shapes">a list which contains elements that are Shape type</param>
        private static void Select_D(List<Shape> shapes)
        {
            Shape square = new Square("square");
            square.SetData();
            Square s = (Square)square;
            if (s.Length <= 0)
            {
                InvalidDimensions();
            }
            else { shapes.Add(square); }
        }

        /// <summary>
        /// If user enters a or A, create an object of Rectangle, set dimensions for it based on input, then add it to the list. 
        /// If any dimensions equal or less than 0, user should be given error message and has another chance to continue. 
        /// However, the instance should not be added into the list.
        /// </summary>
        /// <param name="shapes">a list which contains elements that are Shape type</param>
        private static void Select_A (List<Shape> shapes)
        {
            Shape rectangle = new Rectangle("rectangle");
            rectangle.SetData();
            Rectangle r = (Rectangle)rectangle;
            if (r.Length <= 0 || r.Width <= 0)
            {
                InvalidDimensions();
            }
            else
            {
                shapes.Add(rectangle);
            }
        }

        /// <summary>
        /// If user enters b or B, create an object of Ellipse, set dimensions for it based on input, then add it to the list. 
        /// If any dimensions equal or less than 0, user should be given error message and has another chance to continue. 
        /// However, the instance should not be added into the list.
        /// </summary>
        /// <param name="shapes">a list which contains elements that are Shape type</param>
        private static void Select_B(List<Shape> shapes)
        {
            Shape ellipse = new Ellipse("ellipse");
            ellipse.SetData();
            Ellipse e = (Ellipse)ellipse;
            if (e.Major_Length <= 0 || e.Minor_Length <= 0)
            {
                InvalidDimensions();
            }
            else
            {
                shapes.Add(ellipse);
            }
        }

        /// <summary>
        /// If user enters c or C, create an object of Triangle, set dimensions for it based on input, then add it to the list. 
        /// If any dimensions equal or less than 0, user should be given error message and has another chance to continue. 
        /// However, the instance should not be added into the list.
        /// </summary>
        /// <param name="shapes">a list which contains elements that are Shape type</param>
        private static void Select_C(List<Shape> shapes)
        {
            Shape triangle = new Triangle("triangle");
            triangle.SetData();
            Triangle t = (Triangle)triangle;
            if (t.Base <= 0 || t.Height <= 0)
            {
                InvalidDimensions();

            }
            else
            {
                shapes.Add(triangle);
            }
        }
        /// <summary>
        /// Display the elements in the List<Shape> including author's name, number of instances, and title.
        /// </summary>
        /// <param name="shapes"></param>
        private static void ShowList(List<Shape> shapes)
        {
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Zhiping's Geometry Class:\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"There are {shapes.Count()} objects:\n");
            Console.WriteLine("Shape               Area                Volume            Details       ");
            Console.WriteLine("**********          *****               ******           ***********************");
            foreach(Shape s in shapes)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// When user enter non-positive numbers for the dimensions, error messages should be shown  
        /// and users are given chances to continue.
        /// </summary>
        private static void InvalidDimensions()
        {
            Console.WriteLine("\nInvalid number, please input an positive number!");
            Console.WriteLine("\nPlease any key to continue... ");
            Console.ReadKey();
        }

        }

    
}

