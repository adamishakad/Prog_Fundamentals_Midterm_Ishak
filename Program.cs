// Adam Isak 
// 02/12/2024
// Programming 120 _ W24 _ Midterm _ Menu
using System.ComponentModel.Design;
using System.Drawing;
using System.Reflection.Metadata;
using System.Threading.Channels;
using System.Xml.Serialization;

namespace Prog_Fundamentals_Midterm_Ishak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Label : Start of our Menu:
        Start:

            //Display program information:
            //Console.WriteLine("Adam I");
            // Console.WriteLine("Date: 02-12-2024");
            //Console.WriteLine("Programming 120 - Midterm\n");

            //Console.WriteLine("Midterm App main menu:");
            //Console.WriteLine("1. Personal Calculator");
            //Console.WriteLine("2. Fanancial Calculator");
            // Console.WriteLine("3. Geomety Calculator");
            //Console.WriteLine("4. Cartesian Plane");
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

            if (operation == "1") 
            {
                // 1. Net Income.
            }
            //else if(operation == "2") 
            {
                // 2. Rule of 72.
            }
            //else if(operation == "3")
            {
                // 3. Net Worth.
            }
            //else (operation == "4")
            {
                // 4. Exit.
            }

            //Geometry Calculator;
            
            {
                Console.WriteLine("1.Square");
                Console.WriteLine("2.Rectangle");
                Console.WriteLine("3.Circle");
                Console.WriteLine("4.Right");
                Console.WriteLine("5.Exit Geomety calculator");

                Console.Write("Enter your choice (1-5): ");
                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine("1.CalculateSquareArea");
                Console.WriteLine("4 * 2");
                Console.WriteLine("2.CalculateRectangleArea");
                Console.WriteLine("10.0 * 5.0");
                Console.WriteLine("3.CalculateCircleArea");
                Console.WriteLine("pi * 3.00^");
                Console.WriteLine("4.CalculateConeVolume");
                Console.WriteLine("pi * 12.0^ * 14.0 / 3");
                Console.WriteLine("5. exit");
            }




            Console.WriteLine("4.Cartesian Plane");

            Console.Write("Enter the value of x: ");

            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of y: ");
            int y = int.Parse(Console.ReadLine());

            if (x == 0 && y == 0)
            {
                Console.WriteLine("The point is at the origin.");
            }
            else if (x == 0)
            {
                Console.WriteLine("The point is on the x-axis.");
            }
            else if (y == 0)
            {
                Console.WriteLine("The point is on the y-axis.");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("The point is in the first quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The point is in the second quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The point is in the third quadrant.");
            }
            else (x == 1 && y == -3)
            {
                Console.WriteLine("The point is in the fourth quadrant.");
            }





        }
    }
}
