using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    public interface IPlayerActions
    {       
        void GetHit(int part);
        void OnBlock();
        void OnWound();
        void OnDeath();

        event EventHandler<GameEventArgs> Block;
        event EventHandler<GameEventArgs> Wound;
        event EventHandler<GameEventArgs> Death;
    }
}
