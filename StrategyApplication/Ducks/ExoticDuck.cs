using StrategyApplication.Ducks.Quack;
using System;

namespace StrategyApplication.Ducks
{
    public class ExoticDuck : DuckBase
    {
        public ExoticDuck()
        {
            QuackBehaviout = new ExoticQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm an ExoticDuck");
        }
    }
}
