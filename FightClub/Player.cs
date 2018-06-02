using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    public abstract class Player : IPlayerActions
    {
        public int Hp { get; set; }
        public string Name { get; set; }
        public BodyParts BlockedPart { get; set; }

        public event EventHandler<GameEventArgs> Block;
        public event EventHandler<GameEventArgs> Wound;
        public event EventHandler<GameEventArgs> Death;

        public void GetHit(int bodyPart)
        {
            Hp -= bodyPart;
        }

        public void SetBlock(BodyParts chosenBlock)
        {
            BlockedPart = chosenBlock;
        }
        public void OnBlock()
        {
            GameEventArgs args = new GameEventArgs(Name, Hp);
            Block(this, args);
        }
        public void OnWound()
        {
            GameEventArgs args = new GameEventArgs(Name, Hp);
            Block(this, args);
        }
        public void OnDeath()
        {
            GameEventArgs args = new GameEventArgs(Name, Hp);
            Block(this, args);
        }
    }
}
