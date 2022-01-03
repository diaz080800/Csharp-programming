/*
 * Week 1 - Exercise 5
 * By Christopher Diaz Montoya
 * ID - 24707686
 */

using System;
using static Portfolio1Ex5.Pi; // Needed to call class and access methods within
// Full stop used to access method within the class

namespace Portfolio1Ex5
{
    class Program
    {
        // Returns float and does not accept a parameter.
        // Method is of type float.
        public static float askRadius()
        {
            float inputRadius = 0; // Creates variable for input
            try // Tries and checks code in parenthesis
            {
                Console.Write("What is the radius?: "); // Asks for radius.
                inputRadius = Convert.ToInt32(Console.ReadLine()); // Read input and converts radius input to float.
            }
            catch (Exception message)// If try code does not work then below is printed out
            {
                // Instructs user to input a whole number to not crash the program.
                // Message prints the problem going on, it was assigned next to Exception which is the type of problem
                Console.WriteLine(message + "\nPlease run again and enter a whole number."); // \n for new line
            }
            return inputRadius; // Returns radius input as float.
        }
        /* Returns nothing, method is void, method prints instead.
           Method accepts 2 sloat parameters, needed to calculate the area.
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
            // pi is a constant, varible can not be changed.
            float pi = PiNum(); // Called method as I would with any other method, class was imported at the top.
            // assigned value returned from above method to pi, can be done as method is in another scope.

            float radius = askRadius(); // Calls method to ask user for radius.
            area(pi, radius); // Calls method to calculate the area.
            perimeter(pi, radius); // Calls method to calculate the perimeter.

        /* used https://www.codegrepper.com/code-examples/csharp/c%23+how+to+call+methods+from+another+class 
         * to help with the above.
         */
        }
    }
}
