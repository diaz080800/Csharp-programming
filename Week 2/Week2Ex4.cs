/*
 * Week 2 - Exercise 4
 * By Christopher Diaz Montoya
 * ID - 24707686
 */

using System;

namespace Portfolio2Ex4
{
    class Program
    {
        public static string readInput() // Method to read input 
        {
            Console.WriteLine("Enter a sentence:"); // Ask for input.
            string inp = Console.ReadLine(); // Read input and assgn to varaible.
            return inp; // return string to main.
        }
        public static void ToUpperCase(string LowerCase) // Method = void, no return type, parameter = string type.
        {
            try // Tries code without breaking program
            {
                String UpperCase = ""; // Creat variable to store UpperCase
                for (int x = 0; x < LowerCase.Length; x++) // Iterates theough length of parameter passed into method.
                {
                    if (LowerCase[x] >= 'a' && LowerCase[x] <= 'z') // If in range of lower case between a & z
                    {
                        UpperCase += (char)(LowerCase[x] - 'a' + 'A'); 
                        /* Add and assign a charecter from Lowercase to UpperCase
                         * but first delete from lowercase range and add equivelent in upper case range
                         * x = element/char iterated over. 
                         */
                    }
                    else // If already upper case add and assign to UpperCas whatever element is being iterated
                        // over, element number = x.
                        UpperCase += LowerCase[x];
                }
                Console.WriteLine("Upper case string:");
                Console.WriteLine(UpperCase); // Prints on new line as asked in exercise with UpperCase sentence
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg); // Prints error to help find issue
            }
        }
        static void Main(string[] args)
        {
            string sentence = readInput(); // Calls readInput and input assigned to sentence.
            ToUpperCase(sentence); // Sentence passed as a parameter ToUpperCase to change.

        }
    }
}
/*https://stackoverflow.com/questions/913090/how-to-capitalize-the-first-character-of-each-word-or-the-first-character-of-a
 * Above URL made me realise I could create an alphabet range
 */

