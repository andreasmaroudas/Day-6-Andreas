using ArenaGameEngine;

namespace ArenaGameConsole
{
    class ConsoleGameEventListener : GameEventListener
    {
        public override void GameRound(Hero attacker, Hero defender, int attack)
        {
            string message = $"{attacker.Name} attacked {defender.Name} for {attack} points";
            if (defender.IsAlive)
            {
                message = message + $" but {defender.Name} survived.";
            }
            else
            {
                message = message + $" and {defender.Name} died.";
            }
            Console.WriteLine(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Sir John");
            Rogue rogue = new Rogue("Slim Shady");
            Necromancer necromancer = new Necromancer("Guldan");
            Warrior warrior = new Warrior("Garot");

            Arena arena = new Arena(knight, rogue);
            arena.EventListener = new ConsoleGameEventListener();
            Console.WriteLine("The first fight ended!");

            Console.WriteLine("The second fight begins: ");
            Arena arena2 = new Arena(necromancer, warrior);
            arena2.EventListener = new ConsoleGameEventListener();

            Hero winner = arena.Battle();
            Console.WriteLine($"Battle ended.  The first winner is: {winner.Name}");
            winner = arena2.Battle();
            Console.WriteLine($"Battle ended.  The second winner is: {winner.Name}");
            Console.ReadLine();
        }
    }
}
