/*
 * Week 1 - Exercise 4
 * By Christopher Diaz montoya
 * ID - 24707686
 */

using System;

namespace Portfolio1Ex4
{
    class Program
    {
        // Returns float and does not accept a parameter.
        // Method is of type float.
        public static float askRadius()
        {
            Console.Write("What is the radius?: "); // Asks for radius.
            float inputRadius = float.Parse(Console.ReadLine());
            return inputRadius; // Returns radius input as float.
        }
        /* Returns nothing, method is void, method prints instead.
         *Method accepts 2 sloat parameters, needed to calculate the area.
         */
        public static void area(float pi, float radius)
        {
            float area = pi * radius * radius; // area formula for circle assinged to area.
            Console.WriteLine("The area of the circle is {0}", Math.Round(area, 2)); // Area printed to 2 decimal places.
            // {} is a place holder and is indexed  and filled accordingly after the comma.
        }
        // Returns nothing, method is void, method prints instead.
        // Method accepts 2 float parameters, needed to calculate the perimeter.
        public static void perimeter(float pi, float radius)
        {
            float perimeter = 2 * pi * radius; // perimeter formula for circle assinged to perimeter.
            Console.WriteLine("The perimeter of the circle is {0}", Math.Round(perimeter, 2)); // Perimeter printed to 2 decimal places
            // {} is a place holder and is indexed  and filled accordingly after the comma
            // no neeed to add + to print multiple types.
        }
        static void Main(string[] args)
        {
            const float pi = 3.142f; // pi is a constant, varible can not be changed.

            float radius = askRadius(); // Calls method to ask user for radius.
            area(pi, radius); // Calls method to calculate the area.
            perimeter(pi, radius); // Calls method to calculate the perimeter.
        }
    }
}
