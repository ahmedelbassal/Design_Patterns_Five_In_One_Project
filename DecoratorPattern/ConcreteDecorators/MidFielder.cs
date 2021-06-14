using DecoratorPattern.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorators
{
    class MidFielder: PlayerRole
    {

        PlayerRole _addedRole;

        public MidFielder() { }

        public MidFielder(PlayerRole addedRole) => _addedRole = addedRole;


        public override void AssignPlayer(PlayerRole addedRole)
        {
            _addedRole = addedRole;
        }

        public void Dribble()
        {
            Console.WriteLine("Player Dribble --> (MidFielder concreteDecorator)");
        }

        public override void Responsibility()
        {
            base.PassBall();

            Dribble();

            if (_addedRole != null) _addedRole.Responsibility();

        }
    }
}
