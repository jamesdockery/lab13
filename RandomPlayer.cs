using System;
namespace Lab13
{
    class RandomPlayer : Player
    {
        Random r;

        public RandomPlayer(string name) : base(name)
        {
        }

        public RandomPlayer(String name, Random r) : base (name)
        {
            this.r = r;
        }

        public override string GetRPS()
        {
            int pick = r.Next(1, 4);
            if(pick == 1)
            {
                return RPSEnum.Rock.ToString();
            }else if(pick == 2)
            {
                return RPSEnum.Paper.ToString();
            }else if(pick == 3)
            {
                return RPSEnum.Scissors.ToString();
            }


            return "-1";
        }
    }
}
