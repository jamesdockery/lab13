using System;
using System.Threading;

namespace Lab13
{
    class MainClass
    {
      

        public static void Main(string[] args)
        {
            bool co = true;

            Console.WriteLine("Hello User! Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("Enter your name: ");
            string playerName = Console.ReadLine();
            Human player1 = new Human(playerName);
            while (co)
            {
                player1.GetChoice();

                Console.WriteLine("You chose " + player1.GetRPS());

                RPSApp app = new RPSApp();

                int input = app.Selection();



                Console.WriteLine("Nice! Now lets see what your opponent chooses...");

                Console.WriteLine("ROCK!");
                Thread.Sleep(1000);
                Console.WriteLine("PAPER!");
                Thread.Sleep(1000);
                Console.WriteLine("SCISSORS!");
                Thread.Sleep(1000);
                Console.WriteLine("SHOOT...");
                Thread.Sleep(1250);
                Console.WriteLine("");
                Console.WriteLine("");
                switch (input)
                {
                    case 1:
                        app.RockeyAct();

                        break;

                    case 2:

                        app.RandoAct();
                        break;
                }

                Console.WriteLine("Would you like to continue playing? Y or N:");

                string answer = Console.ReadLine();
                answer.ToLower().Trim();
                if (answer == "y")
                {
                    co = true;
                    Console.Clear();
                }
                else
                {
                    co = false;
                    Console.WriteLine("Thanks for playing! Goodbye...");
                }
            }
        }
    }
}
