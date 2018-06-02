using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{    
    public class Game
    {
        private bool turn = false;

        public int Round { get; } = 1;
        public Player enemy;
        public Player player;

        public Game(string name)
        {
            enemy = new EnemyPlayer();
            player = new MainPlayer(name);
        }
        

    }
}
