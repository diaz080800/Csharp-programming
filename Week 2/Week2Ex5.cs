/*
 * Week 2 - Exercise 5
 * By Christopher Diaz Montoya
 * ID - 24707686
 */

using System;

namespace Portfolio2Ex5
{
    class Program
    {
        public static string userInp()
        {
            Console.WriteLine("Please enter a word:"); // Asks for user input
            string check = Console.ReadLine(); // Reads input
            return check;
        }
        public static bool IsItPalindrome(string check)
        {
            check = check.ToLower(); // Makes it all lower case easier to read
            if (check.Length <= 1) // If 1 letter execute below
                return true; // If 1 letter yes is palindrome
            else
            {
                if (check[0] != check[check.Length - 1])
                    return false; // If first and last letter are not the same return false
                else
                    return IsItPalindrome(check.Substring(1, check.Length - 2)); 
               /*
                * Above else statement loops over method without first and last char.
                * Recursive call back to same function to try with substring until reaches middle of string
                * so length = 1 and can return true or false.
                * */
            }
        }
        static void Main(string[] args)
        {
            string check = userInp(); // Calls funciton, asks for user input and assigns to check.

            bool answer = IsItPalindrome(check); // Check passed as parameter and returns a bool assigned to answer.

            if (answer == false) // If function returns false print below is not palindrome.
            {
                Console.WriteLine(check + " is not a palindrome"); // Prints inputed word with string saying its palindrome.
            }
            else // If function returns true is a palindrome
            {
                Console.WriteLine(check + " is a palindrome");
            }
        }
    }
}

//Tried to store in a empty array and split to compare indexes before but would not work