// Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.
// Test Data:
// Enter a number: 5
// Expected Output:
// 555
// 5 5
// 5 5
// 5 5
// 555
using System;

// This is the beginning of the Exercise13 class
public class Exercise13
{
    // This is the main method where the program execution starts
    public static void Main()
    {
        int x; // Variable to store the number entered by the user

        // Prompting the user to enter a number
        Console.Write("Enter a number: ");
        // Reading the number entered by the user and converting it to an integer
        x = Convert.ToInt32(Console.ReadLine());

        // Printing the number in a specific pattern
        Console.WriteLine("{0}{0}{0}", x); // Prints the number three times in the same line
        Console.WriteLine("{0} {0}", x); // Prints the number twice with a space in between on each line
        Console.WriteLine("{0} {0}", x); // Prints the number twice with a space in between on each line
        Console.WriteLine("{0} {0}", x); // Prints the number twice with a space in between on each line
        Console.WriteLine("{0}{0}{0}", x); // Prints the number three times in the same line
    }
}
