using System;

class Program
{
    static void Main()
    {
        PrintMenu(); // Call PrintMenu to start the program
    }

    // Method to display the menu and handle user input
    static void PrintMenu()
    {
        while (true) // Continuously display the menu
        {
            try
            {
                int option = InputOption(); // Get a new option each time

                switch (option)
                {
                    case 1:
                        SayHelloinFrench();
                        break;
                    case 2:
                        SayHelloinSpanish();
                        break;
                    case 3:
                        SayHelloinGerman();
                        break;
                    case 4:
                        SayHelloinItalian();
                        break;
                    case 5:
                        Console.WriteLine("Exiting application...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

    // Method to get and convert user input, with error handling
    static int InputOption()
    {
        int option = -1;
        while (option == -1) // Continue asking for valid input
        {
            try
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Hello in French");
                Console.WriteLine("2. Hello in Spanish");
                Console.WriteLine("3. Hello in German");
                Console.WriteLine("4. Hello in Italian");
                Console.WriteLine("5. Exit application");

                string input = Console.ReadLine();
                option = int.Parse(input); // Convert user input to integer

                if (option < 1 || option > 5) // Validate the range
                {
                    Console.WriteLine("Please enter a number between 1 and 5.");
                    option = -1; // Reset option to prompt again
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
        return option;
    }

    static void SayHelloinFrench()
    {
        Console.WriteLine("Bonjour!");
    }

    static void SayHelloinSpanish()
    {
        Console.WriteLine("Hola!");
    }

    static void SayHelloinGerman()
    {
        Console.WriteLine("Hallo!");
    }

    static void SayHelloinItalian()
    {
        Console.WriteLine("Ciao!");
    }
}


