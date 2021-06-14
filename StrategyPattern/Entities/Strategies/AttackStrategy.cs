using StrategyPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Entities.Strategies
{
    class AttackStrategy : TeamStrategy
    {
        public override void Play()
        {
            Console.WriteLine("Team is attacking\n");
        }
    }
}
