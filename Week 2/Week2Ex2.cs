/* 
 * Week 2 - Exercise 2
 * By Christopher Diaz Montoya
 * ID - 24707686
 */

using System;

namespace Portfolio2Ex2
{
    class Program
    {
        public static int number() // Method which returns int
        {
            int num = 0; // Varible returned outside try & catch
            try
            {
                Console.WriteLine("Enter a number to check ODD or EVEN and if it's a prime number: "); // Asks user for number
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
                
                /* Learnt from solo learn is an if else statment with the ? operator.
                 * The msg stores whatever the if else outcome is.
                 * num%2==0 evaluates if number has a remainder after fivided by 2
                 * if so it is odd if not it is even.
                 * After the ? the first string = if statement (num%2==0)
                 * the second string after the : = else statement.
                 * Used this as it takes up less lines of code.
                 */
                msg = (num % 2 == 0) ? " is an EVEN number," : " is an ODD number,";

                Console.Write(num + msg);
            }
            catch (Exception message) // Message for what is wrong in program
            {
                Console.WriteLine(message + "oddOrEven"); // String is to identify issue in method
            }
        }
        public static void checkIfPrime(int num)
        {
            bool CheckIfPrime = true;
            string msg; // Can use same varible twice as they are not in the same scope, this one is only for the method.
            try // To not break program and identify issues
            {
                // For loop, loops so input is divided by x multiple times to check if its prime, as x increases
                for (int x = 2; x < num / x; x++)
                {
                    if (num % x == 0) // if num can be divided by x looped into a whole number
                        // it is not a prime as it is divisible by antoher number.
                    {
                        CheckIfPrime = false; // If false and == 1 or another number breaks loop and
                                              // print else condition below as its false
                        break;
                    }
                }
                /* Learnt from solo learn is an if else statment with the ? operator.
                 * The msg stores whatever the if else outcome is.
                 * checkIfPrime == true evaluates if number is a prime number
                 * After the ? the first string = if statement string
                 * the second string after the : = else statement string or a non prime number as it broke the loop.
                 * Used this as it takes up less lines of code.
                 */
                msg = (CheckIfPrime == true) ? (" it is also a prime number") : (" it is also NOT a prime number");

                Console.Write(msg); // Prints outcome of if-else statement
            }
            catch (Exception message) // Incase any erros so they're identfiable
            {
                Console.WriteLine(message + "CheckIfPrime"); // Prints error issue, string identifies method with problem.
            }
        }
        static void Main(string[] args)
        {
            int num = number(); // Calls number method assings input in method to num.
            oddOrEven(num); // Num passed to oddOrEven to check if it is odd or even.
            checkIfPrime(num); // Passes int num to checkIfPrime to check.
        }
    }
}
