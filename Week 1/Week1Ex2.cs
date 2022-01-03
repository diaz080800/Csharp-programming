/* 
 * Week 1 - Exercise 2
 * By Christopher Diaz Montoya
 * ID - 24707686
 */

using System;

namespace Portfolio1Ex2
{
    class Program
    {
        /* 
         * Method asks for name, called askForName
         * Method does not return anything, of type void.
         * This is a method only receiving inputs and printing input.
         */
        public static void askForName()
        {
            // Variables below of type string as we want the users name.
            string firstName, surname; // Easy to understand variables to store both inputs.

            Console.WriteLine("Please enter your name: "); // Asks user for input
            // Console.ReadLine() reads the users input
            firstName = Console.ReadLine(); // First input assigned to firstName,
   
            Console.WriteLine("Please enter your surname: ");
            // Console.ReadLine() reads the users input
            surname = Console.ReadLine(); // Second input for surname

            // Prints both names by calling the respective varibles
            Console.WriteLine("Your name is " + firstName + " " + surname);
        }
        static void Main(string[] args)
        {
            askForName(); // Calls function
        }
    }
}
