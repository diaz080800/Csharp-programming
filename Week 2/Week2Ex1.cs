/*
 * Week 2 - Exercise 1 
 * By Christopher Diaz Montoya
 * ID -24797686
 */

using System;

namespace Portfolio2Ex1
{
    class Program
    {
        public static int number() // Method which returns int
        {
            int num = 0; // Varible returned outside try & catch
            try
            {
                Console.WriteLine("Enter a number to check ODD or EVEN: "); // ASks user for number
                num = Convert.ToInt32(Console.ReadLine()); // Convert. can convert what's in brackets to muiltiple things
                // depedning on what's after the Convert, converted varible assigned num of type int
            }
            catch
            {
                // Incase a whole number is not entered.
                Console.WriteLine("Please enter a whole number or the program will not work properly.");
            }
            return num; // Return input of type int outside of try & catch
        }
        public static void oddOrEven(int num) // Method returns nothing, type void, accepts int parameter.
        {
            try
            {
                string msg; // String to assign to in if else statment

                /*Learnt from solo learn is an if else statment with the ? operator.
                * The msg stores whatever the if else outcome is.
                * num%2==0 evaluates if number has a remainder after fivided by 2
                * if so it is odd if not it is even.
                * After the ? the first string = if statement (num%2==0)
                * the second string after the : = else statement.
                * Used this as it takes up less lines of code.
                */
                msg = (num % 2 == 0) ? " is an EVEN number" : " is an ODD number";
             
                Console.WriteLine(num + msg); // Prints num and outcome of if else statement.
            }
            catch (Exception message) // Message for what is wrong in program
            {
                Console.WriteLine(message + "oddOrEven"); // String is to identify issue in method
            }
        }
        static void Main(string[] args)
        {
            int num = number(); // Calls number method assings input in method to num.
            oddOrEven(num); // Num passed to oddOrEven to check if it is odd or even.
        }
    }
}
