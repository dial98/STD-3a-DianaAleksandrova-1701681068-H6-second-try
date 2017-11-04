using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static double triangleArea(double side, double height)
           {            
            return (side*height)/2;
           }
        static double squareArea(double side)
        {
            return (side * side);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Choose option (triangle, square or radians):");
            string figureType = Console.ReadLine().ToLower();
                        
            Console.WriteLine("Enter side:");
            int side = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height:");
            int height = int.Parse(Console.ReadLine());
            int area=(side*height)/2;

            switch (figureType)
            {
                case "triangle":
                    
                    Console.WriteLine("The area of the {0} is:{1:f2}","triangle", triangleArea(side, height));
                    break;
                case "square":

                    Console.WriteLine("The area of the {0} is: {1:f2}","square",squareArea(side));
                    break;
            }
            
            
            
        }
    }
}
