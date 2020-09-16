// Author: T. Jarrett Hopple
// Class: ISM 4300
// Assignment: Tech Proj #2a
using System;

namespace techproj2a
{
    class Program
    {
        static void Main(string[] args)
        {
            // user input
            Console.WriteLine("Enter an Integer between 1 and 25 to execute an iterative statment: ");
           
            // Try catch will handle error if number entered is not 1-25
            try
            {
                // This will gather data from user input
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                // Execute For loop if between 1 and 25
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a For Loop");
                    Console.WriteLine("The for Loop will iterate " + value_of_input.ToString() + " times.");

                    // For loop 
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered: " + value_of_input + ". This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program ...");

                    Console.ReadKey(true);
                }
                // do this if value is not between 1 and 25
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 25 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again...");
                Console.WriteLine("Press any key to exit the program ..."); // Pause and wait for user to press a key
                Console.ReadKey(true);
            }
        }

    }
}

