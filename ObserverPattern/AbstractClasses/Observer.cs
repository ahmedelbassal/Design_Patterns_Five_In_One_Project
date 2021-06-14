using ObserverPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.AbstractClasses
{
    abstract class Observer
    {
        protected String _Name { get; set; }

        protected FootBall _footBall;

        protected BallPosition _ballPosition;

        protected Observer(String Name,FootBall footBall)
        {
            _Name = Name;
            _footBall = footBall;
        }

        public abstract void Update();
    }
}
