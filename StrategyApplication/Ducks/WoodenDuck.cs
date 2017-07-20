using StrategyApplication.Ducks.Fly;
using StrategyApplication.Ducks.Quack;
using System;

namespace StrategyApplication.Ducks
{
    public class WoodenDuck : DuckBase
    {
        public WoodenDuck()
        {
            FlyBehaviour = new NoFly();
            QuackBehaviout = new NoQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a WoodenDuck");
        }

    }
}
