using System.ComponentModel;
using System.Data;
using System.Security.Cryptography;

namespace MyLittleRPG
{
    internal class Program
    {
        public enum PlayerClass
        {
            Warrior, Mage, Priest, Paladin
        };
        static void Main(string[] args)
        {
            string Name;
            do
            {
                Console.WriteLine("Add meg a karaktered nevét:");
                Name = Console.ReadLine();
                Console.Clear();
            } while (string.IsNullOrEmpty(Name));


            Console.WriteLine("Válassz Class-t:");
            Console.WriteLine("Warrior = 1, Mage = 2, Priest = 3, Paladin = 4");
            PlayerClass SelectedClass;
            var userInput = Console.ReadKey();
            do
            {
                if (userInput.Key == ConsoleKey.D1)
                {
                    SelectedClass = PlayerClass.Warrior;
                    break;
                }

                else if (userInput.Key == ConsoleKey.D2)
                {
                    SelectedClass = PlayerClass.Mage;
                    break;
                }

                else if (userInput.Key == ConsoleKey.D3)
                {
                    SelectedClass = PlayerClass.Priest;
                    break;
                }
                else if (userInput.Key == ConsoleKey.D4)
                {
                    SelectedClass = PlayerClass.Paladin;
                    break;
                }
                else
                {
                    Console.Clear ();
                    Console.WriteLine("Érvénytelen Választás. Próbáld Újra");
                    return;
                }

            } while (true);
            var Player = new Player(Name, SelectedClass);
            Console.Clear();
            Player.Builder();
            Player.CharacterInfo();
            var EnemyNameList = new List<string>() { "Feri", "Zoli", "Tamás", "Martin", "Botond" };
            Random random = new Random();
            var EListIndex = random.Next(EnemyNameList.Count);
            var EnemyName = EnemyNameList[EListIndex];
            EnemyNameList.RemoveAt(EListIndex);

        }
    }
}
