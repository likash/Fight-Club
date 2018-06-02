using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    public class GameEventArgs : EventArgs
    {
        public string Name { get; }
        public int Hp { get; }

        public GameEventArgs(string name, int hp)
        {
            Name = name;
            Hp = hp;
        }
    }
   
}
