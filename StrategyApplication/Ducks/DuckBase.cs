using StrategyApplication.Ducks.Fly;
using StrategyApplication.Ducks.Quack;
using System;

namespace StrategyApplication.Ducks
{
    public abstract class DuckBase
    {
        protected IFlayable FlyBehaviour;

        protected IQuackable QuackBehaviout;

        public DuckBase()
        {
            FlyBehaviour = new FlyWithWings();
            QuackBehaviout = new SimpleQuack();
        }

        public void SetFlyBehaviour(IFlayable newFlyBehaviour) {
            FlyBehaviour = newFlyBehaviour;
        }

        public void SetQuackBehaviour(IQuackable newQuackBehaviout)
        {
            QuackBehaviout = newQuackBehaviout;
        }

        public void Swim()
        {
            Console.WriteLine("I swim");
        }

        public void Quack()
        {
            QuackBehaviout.Quack();
        }

        public void Fly()
        {
            FlyBehaviour.Fly();
        }

        public abstract void Display();
    }
}
