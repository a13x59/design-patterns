using StrategyApplication.Ducks.Fly;
using System;

namespace StrategyApplication.Ducks
{
    public class RubberDuck : DuckBase
    {
        public RubberDuck()
        {
            FlyBehaviour = new NoFly();
        }

        public override void Display()
        {
            Console.WriteLine("i'm a RubberDuck");
        }
    }
}
