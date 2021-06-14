using ObserverPattern.Entities;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // create football , players and refree
            FootBall GameFootBall = new FootBall(new BallPosition {X=2,Y=3,Z=7 });

            Player player1 = new Player("Messi",GameFootBall);
            
            Player player2 = new Player("Cristiano",GameFootBall);
            
            Player player3 = new Player("Ronaldinho",GameFootBall);
            
            Player player4 = new Player("Ibrahimović", GameFootBall);

            Refree refree = new Refree("Pierluigi Collina Refree", GameFootBall);

            // attach players and refree to football
            GameFootBall.AttachObserver(player1);
            GameFootBall.AttachObserver(player2);
            GameFootBall.AttachObserver(player3);
            GameFootBall.AttachObserver(player4);
            GameFootBall.AttachObserver(refree);

            //  change ball position.. when it is changed it will notify players and refree
            Console.WriteLine("Ball position has been changed");

            GameFootBall.SetBallPosition(new BallPosition { X = 4, Y = 9, Z = 10 });


        }
    }
}
