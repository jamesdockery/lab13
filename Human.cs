using System;
namespace Lab13
{
     class Human : Player
    {
        string input;

        public Human(string name) : base( name) 
        {
        }
        public  string GetChoice()
        {
            Console.WriteLine("Hello! " + (Name)
             +". Please select from the following:" +
            	"");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");
            input = Console.ReadLine().Trim();
            return input;
        }
        public override string GetRPS()
        {
            if (input == "1")
            {
                return RPSEnum.Rock.ToString();
            }
            else if (input == "2")
            {
                return RPSEnum.Paper.ToString();

            }
            else if (input == "3")
            {
                return RPSEnum.Scissors.ToString();
            }
            else
            {
                Console.WriteLine("Sorry. The program did not understand your input.");
                return GetRPS();
            }
        }
    }
}
