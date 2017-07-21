using System;

namespace StateApplication.States
{
    public class EngineStartedState : IState
    {
        private readonly Car _car;

        public EngineStartedState(Car car)
        {
            _car = car;
        }

        public void Drive()
        {
            TryDrive();
        }

        public void FillTank()
        {
            Console.WriteLine("Нельзя заправляться с работающим двигателем");
        }

        public void Stop()
        {
            Console.WriteLine("Я и так стою");
        }

        public void TurnKey()
        {
            _car.SetState(_car.FullTank);
            Console.WriteLine("Тссс. Передышка");
        }

        private void TryDrive()
        {
            if (_car.Gasoline > 0)
            {
                _car.SetState(_car.Driving);
                Console.WriteLine("Поехали!");
            }
            else
            {
                _car.SetState(_car.EmptyTank);
                Console.WriteLine("Докатились. Бензин кончился");
            }
        }
    }
}
