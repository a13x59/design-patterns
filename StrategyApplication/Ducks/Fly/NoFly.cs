using System;

namespace StrategyApplication.Ducks.Fly
{
    public class NoFly : IFlayable
    {
        public void Fly()
        {
            Console.WriteLine("...");
        }
    }
}
