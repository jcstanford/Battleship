using System;

namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            getGameInfo();

            // define firm locations for the ship
            // set them random later
            int location1 = 2;
            int location2 = 3;
            int location3 = 4;

            // define a guess variable that will prompt user input
            int guess;

            // define a hits variable that will add up when user guesses correctly
            int hits;

            // define a guesses variable that will add up every incorrect guess
            int guesses;

            // define a boolean variable that will be false until the ship is sunk
            bool isSunk = false;


            // while (isSunk == false) {
            //     // get user input

            // }


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
