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

                // define a guess variable that will prompt user input
                int guess = 0;

                Console.WriteLine("Ready, aim, fire! (Enter a number between 1-6):");

                // get user input
                string input = Console.ReadLine();
                // guess = Int32.Parse(input); not necessary here

                if (!int.TryParse(input, out guess)) {
                    printColorMessage(ConsoleColor.Red, "Please use a valid number!");

                } else {

                    if (guess == location1 || guess == location2 || guess == location3) {
                        hits += 1;
                        printColorMessage(ConsoleColor.Blue, "Hit!");

                        if (hits == 3) {
                            isSunk = true;
                            printColorMessage(ConsoleColor.Blue, "You sank my battleship!");
                        }
                    }
                    else {
                        guesses += 1;
                        printColorMessage(ConsoleColor.Red, "Miss!");
                    }
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

        static void printColorMessage(ConsoleColor color, string message) {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
            }
    }
}
