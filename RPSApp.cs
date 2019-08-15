using System;
namespace Lab13
{
   class RPSApp  {

        public RPSApp()
        {
          
        }

        public int Selection()
        {
            Console.WriteLine("Who would you like to play against?");
            Console.WriteLine("1. Rockey");
            Console.WriteLine("2. Random Player");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        public void RockeyAct() { 

             Rockey rockey = new Rockey("Rockey");
            Console.WriteLine(rockey.GetRPS());
          
        }
        public string RandoAct()
        {
            Random randy = new Random();
            RandomPlayer opponent2 = new RandomPlayer("Joseph", randy);
            Console.WriteLine(opponent2.GetRPS());
            return opponent2.GetRPS();
        }
       
      
    }


      
       



    }
