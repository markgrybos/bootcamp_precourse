using System;
using System.Threading;

namespace w3schools_pre_course
{
    public class Monster
    {
        Random random = new Random();
        public string Type { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Level { get; set; }

        public Monster()
        {
            Type = monsterTypeRandomizer();
            Level = random.Next(1, 5);
            switch (Type)
            {
                case "Goblin":
                    Goblin goblin = new Goblin();
                    Attack = goblin.Attack;
                    Defense = goblin.Defense;
                    break;
                case "Zombie":
                    Zombie zombie = new Zombie();
                    Attack = zombie.Attack;
                    Defense = zombie.Defense;
                    break;
                case "Dragon":
                    Dragon dragon = new Dragon();
                    Attack = dragon.Attack;
                    Defense = dragon.Defense;
                    break;
                case "Orc":
                    Orc orc = new Orc();
                    Attack = orc.Attack;
                    Defense = orc.Defense;
                    break;
                case "Werewolf":
                    Werewolf werewolf = new Werewolf();
                    Attack = werewolf.Attack;
                    Defense = werewolf.Defense;
                    break;
                case "Troll":
                    Troll troll = new Troll();
                    Attack = troll.Attack;
                    Defense = troll.Defense;
                    break;
                case "Vampire":
                    Vampire vampire = new Vampire();
                    Attack = vampire.Attack;
                    Defense = vampire.Defense;
                    break;
                case "Witch":
                    Witch witch = new Witch();
                    Attack = witch.Attack;
                    Defense = witch.Defense;
                    break;
            }
            Attack = Attack * Level;
            Defense = Defense * Level;
        }

        private string monsterTypeRandomizer()
        {
            string[] monsterTypes = new string[] { "Goblin", "Zombie", "Dragon", "Orc", "Werewolf", "Troll", "Vampire", "Witch" };
            string returnType = monsterTypes[random.Next(monsterTypes.Length)];
            return returnType;
        }

        private class Goblin
        {
            public int Attack = 3;
            public int Defense = 3;
        }

        private class Zombie
        {
            public int Attack = 3;
            public int Defense = 1;
        }

        private class Dragon
        {
            public int Attack = 15;
            public int Defense = 10;
        }
        private class Orc
        {
            public int Attack = 7;
            public int Defense = 5;
        }
        private class Werewolf
        {
            public int Attack = 10;
            public int Defense = 4;
        }
        private class Troll
        {
            public int Attack = 3;
            public int Defense = 12;
        }
        private class Vampire
        {
            public int Attack = 6;
            public int Defense = 2;
        }
        private class Witch
        {
            public int Attack = 3;
            public int Defense = 1;
        }
    }

    abstract class Player
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                Monster minion = new Monster();
                Console.WriteLine($"This is a level {minion.Level} {minion.Type}.");
                Console.WriteLine($"It has {minion.Attack} Attack and {minion.Defense} defense.");
                Thread.Sleep(1500);
                i++;
            }
         }
    }
}
