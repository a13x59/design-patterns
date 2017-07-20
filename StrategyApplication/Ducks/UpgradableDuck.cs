using StrategyApplication.Ducks.Fly;
using StrategyApplication.Ducks.Quack;
using System;

namespace StrategyApplication.Ducks
{
    public class UpgradableDuck : DuckBase
    {
        public UpgradableDuck()
        {
            FlyBehaviour = new NoFly();
            QuackBehaviout = new NoQuack();
        }
        
        public override void Display()
        {
            Console.WriteLine("I'm an UpgradableDuck");
        }
    }
}
