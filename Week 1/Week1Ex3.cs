/*
 * Week 1 - Exercise 3 
 * By Christopher Diaz Montoya
 * ID - 24707686
 */

using System;

namespace Portfolio1Ex3
{
    class Program
    {
        // Method returns an integer hence the use of int
        public static int askForNumber()
        {
            Console.WriteLine("Please enter the number of people: "); // Asks user for input on number of people.
            int numNames = Convert.ToInt32(Console.ReadLine()); // Reads above line and converts input to int.
            return numNames; // Assigned input to numNames above and now returning value to main.
        }
        // Method does not return anything = void
        public static void names(int numNames)
        {
            // For loop that only goes up to whatever the input value is passed as a method parameter.
            for (int i = 1; i <= numNames; i++)
            {
                string firstName, surname; // Easy to understand variables 

                // Asks for users name with relevant number.
                // i = number in the loop e.g second loop = second person.
                Console.WriteLine("Person " + i + ", please enter you name: ");
                firstName = Console.ReadLine();

                // Asks for users surname with relevant number
                Console.WriteLine("Person " + i + ", please enter you surname: ");
                surname = Console.ReadLine();

                // Prints out the full name of person as well as number 
                Console.WriteLine("The name of person " + i + " is " + firstName + " " + surname);
            }
        }
        public static void Main(string[] args)
        {
            int num = askForNumber(); // Calls askForNumber method and assigns return value to num
            names(num); // num passed as a parameter to names method
        }
    }
}
