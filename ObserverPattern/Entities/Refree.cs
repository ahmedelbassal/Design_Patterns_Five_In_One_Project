using ObserverPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Entities
{
    class Refree : Observer
    {
     
        public Refree(String Name, FootBall footBall) : base(Name, footBall) { }

        public override void Update()
        {
           
            _ballPosition = _footBall.GetBallPosition();

            Console.WriteLine($"Refree {_Name} is watching ball position at ( x: {_ballPosition.X}| y:  {_ballPosition.Y}| z: {_ballPosition.Z} )");
        }
    }
}
