using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleRPG
{
    internal class Player
    {
        public string Name { get; }
        private int Health; 
        private double Defense;
        private double Attack;
        private double AttackPower;
        private double SpellPower;
        private int Level;
        private int Experience;
        public Program.PlayerClass PlayerClass { get; }

        public Player(string _name, Program.PlayerClass _playerClass)
        {
            Name = _name;
            PlayerClass = _playerClass;
        }
        public void Builder()
        {
            if (PlayerClass == Program.PlayerClass.Warrior)
            {
                Health = 200; Defense = 60; AttackPower = 2; Attack = 30; Level = 1; Experience = 0;
            }
            if (PlayerClass == Program.PlayerClass.Mage)
            {
                Health = 120; Defense = 30; SpellPower = 4; Attack = 15; Level = 1; Experience = 0;
            }
            if (PlayerClass == Program.PlayerClass.Priest)
            {
                Health = 140; Defense = 45; SpellPower = 3; Attack = 20; Level = 1; Experience = 0;
            }
            if (PlayerClass == Program.PlayerClass.Paladin)
            {
                Health = 180; Defense = 50; AttackPower = 1.5; Attack = 40; Level = 1; Experience = 0;
            }
            
        }
        public void CharacterInfo()
        {
            if (PlayerClass == Program.PlayerClass.Warrior || PlayerClass == Program.PlayerClass.Paladin)
            {
                Console.WriteLine($"Karaktered Neve: {Name}\nClassod: {PlayerClass}\nÉleted: {Health}\nSebzésed: {Attack}\nVédelmed:{Defense}\nSebzés szorzód:{AttackPower}");
            }
            else
            {
                Console.WriteLine($"Karaktered Neve: {Name}\nClassod: {PlayerClass}\nÉleted: {Health}\nSebzésed: {Attack}\nVédelmed:{Defense}\nSebzés szorzód:{SpellPower}");
            }
        }

        public void Damage(Enemy target)
        {
            Random random = new Random();
            var damage = ((AttackPower * Attack) - random.Next(0, 16)) * (Level * 1.5);
            damage = Math.Max(0, damage);

            target.Health = Math.Max(0, target.Health-(int)damage);
            Console.WriteLine($"{Name} megtámadta {target.Name}-t és {damage:0} sebzést okozott");
        }
        public bool IsAlive() => Health > 0;
        public void LevelUp()
        {

        }
    }
}
