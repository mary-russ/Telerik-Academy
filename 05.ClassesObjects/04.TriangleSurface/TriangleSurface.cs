using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.TriangleSurface
{
    class TriangleSurface
    {
        static void SideAltitude()
        {
            Console.Write("Enter side of a triangle: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter altitude to this side: ");
            double h = double.Parse(Console.ReadLine());
            double surface = (a * h) / 2;
            Console.WriteLine("The surface is: ", surface);
        }

        static void ThreeSides()
        {
            Console.Write("Enter first side of a triangle: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second side of a triangle: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter third side of a triangle: ");
            double c = double.Parse(Console.ReadLine());
            double halfPerimeter = (a + b + c) / 2;
            double surface = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            Console.WriteLine("The surface is: ", surface);
        }

        static void TwoSidesAngle()
        {
            Console.Write("Enter first side of a triangle: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second side of a triangle: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter an angle between these two sides: ");
            double x = double.Parse(Console.ReadLine());
            double angleInRadian = (x * Math.PI) / 180;
            double surface = (a * b * Math.Sin(angleInRadian)) / 2;
            Console.WriteLine("The surface is: ", surface);
        }

        static void Main(string[] args)
        {
            /*Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math */

            Console.WriteLine("For calculating surface of a triangle, enter 1, 2 or 3: ");
            Console.WriteLine("1 by given one side and an altitude to it, " );
            Console.WriteLine("2 by given three sides and ");
            Console.WriteLine("3 by given two sides and an angle between them.");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: SideAltitude(); break;
                case 2: ThreeSides(); break;
                case 3: TwoSidesAngle(); break;
                default: Console.WriteLine("You didn't enter 1, 2 or 3.");
                    break;
            }

        }
    }
}
