using System;

namespace StrategyApplication.Ducks.Fly
{
    public class FlyWithWings : IFlayable
    {
        public void Fly()
        {
            Console.WriteLine("I Fly with wings");
        }
    }
}
