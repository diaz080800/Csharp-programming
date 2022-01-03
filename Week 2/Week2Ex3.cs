/* 
 * Week 2 - Exercise 3
 * By Christopher Diaz Montoya
 * ID - 24707686
 */

using System;

namespace Portfolio2Ex3
{
    class Program
    {
        public static int numberOfLinesInput() // Method returns type int no neet for parameter
        {
            int len = 0;
            try
            {
                Console.WriteLine("Enter the maximum number of lines of *: ");
                len = Convert.ToInt32(Console.ReadLine()); // Convert input into int
            }
            catch (Exception msg) // Check any issues I made
            { 
                Console.WriteLine(msg + "numberOfLineInput"); // String to identify problem with method
            }
            if (len % 2 == 1) // If numnber is odd the return len = input
                return len;
            else
                Console.WriteLine("Please retry and enter an ODD number"); // Forced my own error handling
            // This was to ensure star was even as the exercise requested
                return 0; // If input was even return 0 which does not allow the printStar method to run.
        }
        public static void printStar(int len) // parameter type int no need for return, prints so used void.
        {
            try // To not break the program and identify problems.
            {
                // First for loop is for the y axis so print down wards
                for (int y = 0; y < len; y++)
                {
                    // Inner loop helps print for the x axis across
                    for (int x = 0; x < len; x++)
                    {
                        // If x and y axis are the same number print, or if they add up to -1 under
                        // the inputted length then print, x == y is the constant to print an * in the 
                        // x shape in the middle
                        if ((x == y) || (x + y == (len - 1)))
                            Console.Write("*"); // Prints on x- axis
                        else
                            Console.Write(" "); // Provides space on the x axis to print the X
                    }
                    // When inner loop has done everything across it then breaks to outter
                    // loop where it goes down to the next line (below this) ir prints a new line
                    // int the y axis
                    Console.WriteLine("\n");
                }
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg + "printStar"); // Prints issue with method, string is to itdentify method with issue.
            }
        }
        static void Main(string[] args)
        {
            int num = numberOfLinesInput(); // Calls input method and stures returned value in num.
            printStar(num); // Uses input value to print star lengh, int passed as printStar parameter.
        }
    }
}
