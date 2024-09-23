using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();


        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int SquaredNumber = SquareNumber(userNumber);

        DisplayResult(userName,SquaredNumber);
        
            
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
            
        }

        static string PromptUserName()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
        
        static int SquareNumber(int number)
        {
            int square = number * number;

            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name} the number of your square is {square}");
        }

    }
}