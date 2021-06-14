using DecoratorPattern.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorators
{
    class Defender : PlayerRole
    {
        PlayerRole _addedRole;

        public Defender() { }

        public Defender(PlayerRole addedRole) => _addedRole = addedRole;

        public override void AssignPlayer(PlayerRole addedRole)
        {
            _addedRole = addedRole;
        }

        protected void Defend()
        {
            Console.WriteLine("Player Defend ---> (Defender concreteDecorator)");
        }

        public override void Responsibility()
        {
            base.PassBall();

            Defend();

            if (_addedRole != null) _addedRole.Responsibility();
        }
    }
}
