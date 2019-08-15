using System;
namespace Lab13
{
    class Rockey : Player
    {
        
        public Rockey(String name) : base(name)
        {
        }

        public override string GetRPS()
        {
            return "Rock";
        }
    }
}
