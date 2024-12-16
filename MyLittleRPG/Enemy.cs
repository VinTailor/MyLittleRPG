using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleRPG
{
    internal class Enemy
    {
        public string Name;
        public int Health;
        private int Attack;
        private int Defense;
        private int Level;
        public Enemy(string _name,int _health, int _attack, int _defense, int _level)
        {
            Name = _name;
            Health = _health;
            Attack = _attack;
            Defense = _defense;
            Level = _level;
        }
    }
}
