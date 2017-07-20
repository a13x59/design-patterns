using System;

namespace StrategyApplication.Ducks
{
    public class SimpleDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("I'm a SimpleDuck");
        }
    }
}
