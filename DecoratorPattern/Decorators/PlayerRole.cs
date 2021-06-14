using DecoratorPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    abstract class PlayerRole : Player
    {
        protected override void PassBall()
        {
            Console.WriteLine("Player passes the ball  --> (Decorator func)");
        }

        public abstract void AssignPlayer(PlayerRole addedRole);

        public abstract void Responsibility();
    }
}
