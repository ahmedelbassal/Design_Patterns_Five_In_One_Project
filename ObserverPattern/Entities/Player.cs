using ObserverPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Entities
{
    class Player : Observer
    {
      
        public Player(String Name,FootBall footBall) : base(Name, footBall) { }

        public override void Update()
        {
            _ballPosition = _footBall.GetBallPosition();

            Console.WriteLine($"Player {_Name} move to ball positon ( X : {_ballPosition.X}| Y :  {_ballPosition.Y}| Z : {_ballPosition.Z})");
        }
    }
}
