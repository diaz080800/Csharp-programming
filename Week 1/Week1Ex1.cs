/*
 * Week 1 - Exercise 1
 * By Christopher Diaz Montoya
 * ID - 24707686
 */

using System;

namespace Portfolio1Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            Console.WriteLine("Enter value 1:");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter value 2: ");
            s2 = Console.ReadLine();
            Console.WriteLine("The entered values are: " + s1 + " and " + s2);
            int i1, i2;
            i1 = Convert.ToInt32(s1);
            i2 = Convert.ToInt32(s2);
            Console.WriteLine("The sum is: " + i1 + i2); // Parenthesis removed around i1 and i2
        }
    }
}
/* 
 * The parenthesis help read the code, the plus signs in line 24 are to print out 
 * multiple variables on one line, if the two variables are of different types it will print out
 * the two varables side by side, if they are of both numerical type then it would be a math
 * operator. As it is the first case but with 3 variables the output is (2+2=22) instead of the sum of 
 * two numbers (2+2=4). It just prints what is stored in the variable. The parenthesis
 * helped identify a math equation by forcing whatever was in the brackets to be added.
 */
