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
        public int Health { get; set; }

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
            Health = 5 * Level;
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
            public int Defense = 7;
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
            public int Defense = 6;
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

    class Player
    {
        public int Health { get; set; }
        public int Attack { get; set; }
        public string Name { get; set; }
        public string AttackStyle { get; set; }

        public Player(string playerName, string playerAttackStyle)
        {
            Name = playerName;
            if (playerAttackStyle.ToLower() == "metal")
            {
                AttackStyle = "metal";
                Attack = 6;
                Health = 10;
            }
            else if (playerAttackStyle.ToLower() == "magic")
            {
                AttackStyle = "magic";
                Attack = 10;
                Health = 5;
            }
            else
            {
                AttackStyle = "bare fist";
                Attack = 3;
                Health = 5;
            }
        }
        public int attackTarget(int monsterHealth, int monsterDefense)
        {
            int playerAttack = Attack - monsterDefense;
            Console.WriteLine($"{Name} is attacking for {playerAttack} damage! ({monsterDefense} damage was blocked)");
            return monsterHealth = monsterHealth - playerAttack;

        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name combatant?");
            string name = Console.ReadLine();
            Console.WriteLine("Howdy, do you fight with 'metal' or 'magic'?");
            string attackStyle = Console.ReadLine();
            Player player = new Player(name, attackStyle);
            Console.WriteLine($"Welcome {player.Name}! Prepare your {player.AttackStyle.ToUpper()} you have {player.Health} health and an attack of {player.Attack}");

            for (int i = 0; i < 100; i++)
            {
                Monster minion = new Monster();
                Console.WriteLine($"This is a level {minion.Level} {minion.Type}.");
                Console.WriteLine($"It has {minion.Attack} attack and {minion.Defense} defense with a total of {minion.Health} health");

                while (minion.Health > 0)
                {
                    if (player.Attack < minion.Defense)
                    {
                        Console.WriteLine("You are unable to get through their defenses! You have died!");
                        break;
                    }
                    else
                    {
                        minion.Health = player.attackTarget(minion.Health, minion.Defense);
                    }
                }
                Console.WriteLine("Monster has been slain!");
                Thread.Sleep(1500);
                i++;
                string end = Console.ReadLine();
                if (end.ToLower() == "q")
                {
                    break;
                }
            }
         }
    }
}
