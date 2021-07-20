using System;

namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            // run game info function
            getGameInfo();

            // define firm locations for the ship
            // set them random later
            int location1 = 2;
            int location2 = 3;
            int location3 = 4;

            // define a guess variable that will prompt user input
            int guess;

            // define a hits variable that will add up when user guesses correctly
            int hits = 0;

            // define a guesses variable that will add up every incorrect guess
            int guesses = 0;

            // define a boolean variable that will be false until the ship is sunk
            bool isSunk = false;

            // ask user for their name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome {0}, let's play battleship!", name);


            while (isSunk == false) {
                // get user input
                Console.WriteLine("Enter a number between 1 and 6: ");
                guess = Console.ReadLine();

                if (guess != Int32.TryParse(1, 6)) {
                    Console.ForegroundColor = ConsoleColor.Red;           
                    Console.WriteLine("Please enter a valid number (1-6)");
                    Console.ResetColor();
                }

                if (guess != location1 || guess != location2 || guess != location3) {
                    Console.ForegroundColor = ConsoleColor.Red;           
                    Console.WriteLine("MISS! Try again");
                    guesses = guesses + 1;
                    Console.ResetColor();
                }

            }


        }

        static void getGameInfo() {
            string appName = "Battleship";
            string appVersion = "1.0.1";
            string appAuthor = "Colin Stanford with aid from Head First JS book";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1}, by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
    }
}
