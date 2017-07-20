using System;

namespace StrategyApplication.Ducks.Quack
{
    public class NoQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}
