/*
 * Week 2 - Exercise 6
 * By Christopher Diaz Montoya
 * ID - 24707686
 */

using System;

namespace Portfolio2Ex6
{
    class Program
    {
        public static void guessNumberGame() // Method for game, does not return any type
        {
            Random r = new Random(); // Initilazes random class gives r random value
            int r_num = r.Next(100); // r.Next() insures value is under number in (), assigned to r_num

            int x = 0; // Assigns 0 for loop counter

            while (x < 5) // Allows for 5 loops, x < 5, counter starts form 0
            {
                Console.WriteLine("Guess the random number between 0 - 100: "); // Allows for 1 guess each loop.
                Console.WriteLine(r_num); // This was used to test program to ensure it worked.
                int guess = Convert.ToInt32(Console.ReadLine()); // Converts string input to int.
                x++; // Each loop counter goes up 1

                int diff = (guess - r_num); 
                /*
                 * Here diff is the value of the (users guess - the random number), this can only give
                 * valus in a range of positive and negative numbers, this was used to calc range to
                 * give a hint to the guess
                 */

                if (diff == 0) // If diff == 0, means the guess was == random number.
                {
                    Console.WriteLine("You guessed the number!");
                    break; // Breaks the loop as the game is finished, user can still have another go see Line 88-91
                }
                else if (guess > 100 || guess < 0) // If guess is biger then 100 OR less then 0 it is invalid, another chance
                {
                    Console.WriteLine("You did not enter a valid number, please enter a number between 0 - 100");
                }
                else if (diff < 10 && diff > -10) 
                /* 
                 * Here I started with the numbers with the lowest range if diff to r_num is in between
                 * 10 and -10 it is in the somewhat high or somewhat low range.
                 * Conditional operator && was used to make sure number is inbetween both.
                 */
                {
                    if (guess > r_num) // If guess is bigger than r_num prints somewhat high
                    {
                        Console.WriteLine("Somewhat High");
                    }
                    else // Else it is opposite and prints somewhat low
                    {
                        Console.WriteLine("Somewhat Low");
                    }
                }
                else if ((diff < 20 && diff >= 10) || (diff > -20 && diff <= -10))
                {
                    /* 
                     * Here two conditional operators were used, the operator AND (&&) and the operator
                     * OR (||) were used to ensure if guess was smaller then the random number and it was negative
                     * to still be read and ensure it is in moderately low range
                     * Brackets within the OR operator holding the AND operator is to ensure either one or the other
                     * condition is met.
                     * The AND is used to ensure the diff is in he specific range so it can print an accurate 
                     * guess.
                     */
                    if (guess > r_num) // if guess is bigger than r_num prints moderately high
                    {
                        Console.WriteLine("Moderately High");
                    }
                    else // Else it is opposite and prints moderately low
                    {
                        Console.WriteLine("Moderately Low");
                    }
                }
                else if ((diff < 50 && diff >= 20) || (diff > -50 && diff <= -20)) 
                    // Again the same two conditional operators are used to ensure value is in one
                    // raneg or another to see how far off the number the user is.
                {
                    if (guess > r_num)
                    {
                        Console.WriteLine("High");
                    }
                    else
                    {
                        Console.WriteLine("Low");
                    }
                }
                else if (diff >= 50 || diff <= -50)
                {
                    if (guess > r_num)
                    {
                        Console.WriteLine("Very High");
                    }
                    else
                    {
                        Console.WriteLine("Very Low");
                    }
                }
            }
            Console.WriteLine("Would you like to play again? Enter Y or N: "); // Asks if player wants to go again
            string again = Console.ReadLine(); // Reads and assigns input to again.
            if (again == "Y" || again == "y") // If player chooses Y exectue below, if choose N back to main.
                guessNumberGame(); // Calls method again to play again if user types Y. recursive code learnt in week 4 lecture.
        }
        static void Main(string[] args)
        {
            guessNumberGame(); // Calls and plays game
            Console.WriteLine("Thank you for playing!"); // If player chooses to not play again this prints.
        }
    }
}
