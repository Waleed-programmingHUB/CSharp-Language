using System;
/*
 * 
 *  Write a Program to take user input to perform arithematic operation without close the console working infinitely...
 *  In C# Language .NET @2021 
 *  
 *  Author : Waleed Ali Sarwar  
 *  
 *  Using Statements
 *  -> 1. While Loop
 *  -> 2. Switch Statement
 *  -> 3. Try Catch Exception Handler
 *  
*/

namespace ProgramOne
{
    class Program
    {
        static void Main(string[] args)
        {
        // Passing a Operation which of the user need Arithematic Operation

                string operation;

                Console.WriteLine("What you want to need the Arithematics Operation \nType Operator");
                // Fill the Colored Text to the Console
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("For Addition press -> + \nFor Multiplication press -> x\nFor Division press -> / \nFor Subtraction press -> - \n");
                // Reset Color here
                Console.ResetColor();

                operation = Console.ReadLine();

                // Taking a user input

                switch (operation)
                {
                    // For Addition
                    case "+":
                        while (true)
                        {
                        // Catch an error for cheap if user inputs are not match to the following terms
                            try
                            {
                                Console.WriteLine("Addition Operation\nEnter a number");
                                int input_one = int.Parse(Console.ReadLine());

                                Console.WriteLine("Enter a number");
                                int input_two = int.Parse(Console.ReadLine());
                                int answer = input_one + input_two;
                                Console.WriteLine($"Output : Sum of {input_one} + {input_two} = {answer}");
                            }
                            catch (Exception) {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Math Error");
                                Console.ResetColor();
                            }
                        }
      
                    // For Subtracttion
                    case "-":
                        while (true)
                        {
                            // Catch an error for cheap if user inputs are not match to the following terms
                                try
                                {
                                    Console.WriteLine("Subtraction Operation\nEnter a number");
                                    int input_one = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter a number");
                                    int input_two = int.Parse(Console.ReadLine());

                                    int answer = input_one - input_two;
                                    Console.WriteLine($"\nOutput : Subtract of {input_one} - {input_two} = {answer}");
                                }catch(Exception){
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Math Error");
                                    Console.ResetColor();

                            }
                    }
                    // For Multiplication
                    case "x":
                        while (true)
                        {
                            // Catch an error for cheap if user inputs are not match to the following terms
                                try
                                {
                                    Console.WriteLine("Multiplication Operation\nEnter a number");
                                    int input_one = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter a number");
                                    int input_two = int.Parse(Console.ReadLine());

                                    int answer = input_one * input_two;
                                    Console.WriteLine($"\nOutput : Sum of {input_one} x {input_two} = {answer}");
                                }catch(Exception){
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Math Error");
                                    Console.ResetColor();

                                }
                        }
                       
                       
                    // For Division
                    case "/":
                        while (true)
                        {
                        // Catch an error for cheap if user inputs are not match to the following terms
                        try{
                                Console.WriteLine("Multiplication Operation\nEnter a number");
                                int input_one = int.Parse(Console.ReadLine());

                                Console.WriteLine("Enter a number");
                                int input_two = int.Parse(Console.ReadLine());

                                int answer = input_one / input_two;
                                // Set the Color Of Console Answer Output
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nOutput : Divide of {input_one} / {input_two} = {answer}");
                                Console.ResetColor();
                            }
                            catch(Exception){
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Math Error");
                                Console.ResetColor();

                            }
                        }      
                       
                    default:
                    // Show Message Error
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Error : Invalid Input");
                        Console.ResetColor();
                    break;
                }

        } 
    }
}
