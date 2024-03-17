// Adam Isak 
// 02/12/2024
// Programming 120 _ W24 _ Midterm _ Menu
using System.ComponentModel.Design;
using System.Threading.Channels;
using System.Xml.Serialization;

namespace Prog_Fundamentals_Midterm_Ishak
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Label : Start of our Menu:
        Start:

            // Display program information:
           // Console.WriteLine("Adam I");
           // Console.WriteLine("Date: 02-12-2024");
           // Console.WriteLine("Programming 120 - Midterm\n");

           // Console.WriteLine("Midterm App main menu:");
           //Console.WriteLine("1. Personal Calculator");
            //Console.WriteLine("2. Fanancial Calculator");
           // Console.WriteLine("3. Geomety Calculator");
           // Console.WriteLine("4. Cartesian Plane");
            //Console.WriteLine("5. Exit");
            //Console.WriteLine("Select an option");

            //string choice = Console.ReadLine();

            // Calculator
            //if (choice == "1") ;
            {
            // Personal Calculator:

            // Label : Start of Calculator:
            //CalculatorStart:

                // Display the name of the Calculator app and prompt the user to enter a number or type 'exit' to  return to the main menu.
                //Console.WriteLine("\nCalculator App");
               // Console.WriteLine("Enter a number (or type 'exit' to return to main menu):");
               // string input = Console.ReadLine();

                // Check if the wnats to exit the calculator app.
                //if (input.ToLower() == "exit") goto Start;

                //double initialNumber; // Variable to store the first user input as a number.

                // Attempt to parse the user input into a double. If the input is not a valid number, catch the FormatException and prompt again.
            }
            //try
            {
                //initialNumber = double.Parse(input);

            }
           //catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
                //goto CalculatorStart;
            }
            // Display options for mathematical operations: Add, Subtract, Multiply, Divide or Exit the calculator app.
               Console.WriteLine("Operation: 1. Add, 2. Subtract, 3. Multuply, 4.Divide, 5. Exit");
               Console.Write("Select an operation:");

           string operation = Console.ReadLine();
            double initialNumber = 20;
            double secondNumber = 5;

            if (operation == "1")
            {
               // Addition operation.
               double sum = initialNumber + secondNumber;
                Console.WriteLine($"The sum of {initialNumber} + {secondNumber} ={sum}");
            }
           else if (operation == "2")
           {
                 //Subtraction operation.
                double result = initialNumber - secondNumber;
                Console.WriteLine($"Subtraction:{initialNumber} - {secondNumber} = {result}");
            }
            else if (operation == "3")
            {
                // Multiply operation.
                double result = initialNumber * secondNumber;
                Console.WriteLine($"Multiplication: {initialNumber} * {secondNumber} ={result}");
            }
           else if (operation == "4") 
            {
                 //Divide operation.
                double result = initialNumber / secondNumber;
                Console.WriteLine($"Division: {initialNumber} / {secondNumber} ={result}");
            }
            else if (operation == "5")
            {
                goto Start;
            }
            else
            {
                Console.WriteLine("Invalid operation, please try again");
               goto Start;
            }

            //----- Financial Calculator ---
               // Console.WriteLine("Options: 1. Net Income, 2. Rule of 73, 3. Net Worth, 4. Exit");
               // Console.Write("Select an operation:");
               // string operation = Console.ReadLine();

            if (operation == "1") ;
            {
                // 1. Net Income.
            }
            else if(operation == "2") ;
            {
                // 2. Rule of 72.
            }
            else if(operation == "3");
            {
                // 3. Net Worth.
            }
            else if(operation == "4");
            {
                // 4. Exit.
            }

            











        }
    }
}
