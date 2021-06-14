using BuilderPattern.AbstractClasses;
using BuilderPattern.Entities;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create director and builders
            Director director = new Director();

            Builders builder1 = new Builder1Constitues();
            Builders builder2 = new Builderr2Constitues();
            Builders builder3 = new Builder3Constitues();

            // Construct two products
            director.Construct(builder1);
            Ground g1 = builder1.GetGround();
            g1.Representaion();

            director.Construct(builder2);
            Ground g2 = builder2.GetGround();
            g2.Representaion();



            director.Construct(builder3);
            Ground g3 = builder3.GetGround();
            g3.Representaion();

        }
    }
}
