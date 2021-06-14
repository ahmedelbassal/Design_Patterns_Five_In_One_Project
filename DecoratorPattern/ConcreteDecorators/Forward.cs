using DecoratorPattern.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorators
{
    class Forward : PlayerRole
    {

        PlayerRole _addedRole;

        public Forward() { }

        public Forward(PlayerRole addedRole) => _addedRole = addedRole;

        public override void AssignPlayer(PlayerRole addedRole)
        {
            _addedRole = addedRole;
        }

        protected void ShootGoal()
        {
            Console.WriteLine("Player Shoot (Forward concreteDecorator)");
        }

        public override void Responsibility()
        {
            base.PassBall();

            ShootGoal();

            if (_addedRole != null) _addedRole.Responsibility();
        }
    }
}
