

using System;

class Calculator
{
    static void Main()
    {
        double num1, num2, result = 0;
        string operation;
        string continueCalculation;
        bool isFirstCalculation = true;  // Flag to check if it's the first calculation

        Console.Clear();  // Clears the console screen initially

        Console.WriteLine("Welcome to the Console Calculator!");

        // First calculation block - it runs only once
        if (isFirstCalculation)
        {
            // Prompt for both numbers on the first calculation
            Console.Write("Enter the first number: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            Console.Write("Enter the second number: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            // Ask for the operation and perform the calculation
            Console.Write("Enter an operation (+, -, *, /): ");
            operation = Console.ReadLine();

            // Perform the calculation based on the operation
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        return;  // Exit the program if division by zero is attempted
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please choose from +, -, *, or /.");
                    return;  // Exit the program if an invalid operation is entered
            }

            Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");
            isFirstCalculation = false;  // Set the flag to false after the first calculation
        }

        // Enter the loop after the first calculation
        do
        {
            Console.WriteLine(); // Add a blank line for better readability
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Perform another operation with the result number.");
            Console.WriteLine("2. Perform another operation with new numbers.");
            Console.WriteLine("3. Exit.");
            Console.Write("Enter your choice (1/2/3): ");
            continueCalculation = Console.ReadLine();

            if (continueCalculation == "1")  // Use the result number for the calculation
            {
                num1 = result;  // Use the result from the previous calculation
                Console.Clear(); // Clears the console to make the UI clean before the next calculation
                Console.WriteLine($"Using result: {result} as the first number."); // Display the result as the first number

                // Prompt for the second number
                Console.Write("Enter the second number: ");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                // Ask for the operation and perform the calculation
                Console.Write("Enter an operation (+, -, *, /): ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                            continue;  // Prompt the user to try again (without exiting the program)
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please choose from +, -, *, or /.");
                        continue;  // Continue to the next iteration if the operation is invalid
                }

                Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");
            }
            else if (continueCalculation == "2")  // Perform new calculation with new numbers
            {
                // Prompt for both numbers for the new calculation
                Console.Write("Enter the first number: ");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                Console.Write("Enter the second number: ");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                // Ask for the operation and perform the calculation
                Console.Write("Enter an operation (+, -, *, /): ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                            continue;  // Continue prompting if division by zero
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please choose from +, -, *, or /.");
                        continue;  // Continue to the next iteration if the operation is invalid
                }

                Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");
            }

        } while (continueCalculation == "1" || continueCalculation == "2");

        Console.WriteLine("Thank you for using the Calculator! Goodbye.");
    }
}
