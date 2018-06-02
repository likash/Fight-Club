using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    public class MainPlayer : Player
    {
        public MainPlayer(string name)
        {
            Hp = 100;
            Name = name;
        }       

        public new void GetHit(int bodyPart) { }
       

    }
}
