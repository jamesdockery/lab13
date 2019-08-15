using System;
using System.Collections.Generic;
using System.Text;
namespace Lab13
{
    abstract class Player
    {
        public string Name { get; set; }
        public abstract String GetRPS();
       public Player(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }

  
}
