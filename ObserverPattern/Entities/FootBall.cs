using ObserverPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Entities
{
    class FootBall : Ball
    {
        BallPosition _myPosition;


        public FootBall(BallPosition myPosition) => _myPosition = myPosition;

        public BallPosition GetBallPosition() 
        {
           
            return _myPosition; 
        
        }

        public void SetBallPosition(BallPosition myPosition)
        { 
            _myPosition = myPosition;

            base.NotifyObservers();
        
        }


        
    }
}
