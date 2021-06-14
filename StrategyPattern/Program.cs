using StrategyPattern.AbstractClasses;
using StrategyPattern.Entities;
using StrategyPattern.Entities.Strategies;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Team Eagles = new Team();

            Console.WriteLine("After setting attack strategy");
            Eagles.SetStrategy(new AttackStrategy ());

            Eagles.PlayGame();

            Console.WriteLine("After Change to Defend strategy");
            Eagles.SetStrategy(new DefendStrategy ());

            Eagles.PlayGame();

            Console.WriteLine("Generate another team and put defend strategy in its constructor");
            Team newTeam = new Team(new DefendStrategy());

            newTeam.PlayGame();
        }
    }
}
