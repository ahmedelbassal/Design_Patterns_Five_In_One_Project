using DecoratorPattern.ConcreteDecorators;
using DecoratorPattern.Decorators;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Create attack player then assignplayer new defender then assignplayer new midFielder");
            Forward player1 = new Forward();

            player1.AssignPlayer(new Defender());

            player1.AssignPlayer(new MidFielder());

            player1.Responsibility();

            Console.WriteLine("\nCreate defender player then assignplayer new Midfiler");

            Defender player2 = new Defender();

            player2.AssignPlayer(new MidFielder());

            player2.Responsibility();

        }
    }
}
