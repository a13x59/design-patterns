using System;

namespace StateApplication.States
{
    public class FullTankState : IState
    {
        private readonly Car _car;

        private static Random _rnd;

        public FullTankState(Car car)
        {
            _car = car;
            _rnd = new Random();
        }

        public void Drive()
        {
            Console.WriteLine("Сначала заведи меня");
        }

        public void FillTank()
        {
            Console.WriteLine("В меня столько не влезет");
        }

        public void Stop()
        {
            Console.WriteLine("Я и так стою");
        }

        public void TurnKey()
        {
            int value = _rnd.Next(5);

            if (value != 4)
            {
                _car.SetState(_car.EngineStarted);
                Console.WriteLine("Дрын дын дын дын тррррррррррр");
            }
            else
            {
                Console.WriteLine("Заглох");
            }
        }
    }
}
