using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleRPG
{
    internal class Fight
    {
        Player Player;
        Enemy Enemy;
        public Fight(Player _player, Enemy _enemy)
        {
            Player = _player;
            Enemy = _enemy;
        }
    }
}
