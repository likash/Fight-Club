using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    public class EnemyPlayer : Player
    {
        public EnemyPlayer()
        {
            Hp = 100;
            Name = "Enemy";
        }
        public new void GetHit(int bodyPart) { }
        public void SetBlock()
        {
            Random randomBlock = new Random();            
            BlockedPart = randomBlock.Next(0, 2);
        }
    }
}
