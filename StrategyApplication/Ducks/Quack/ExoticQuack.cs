using System;

namespace StrategyApplication.Ducks.Quack
{
    public class ExoticQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
}
