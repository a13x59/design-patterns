using System;

namespace StateApplication.States
{
    public class DrivingState : IState
    {
        private readonly Car _car;

        public DrivingState(Car car)
        {
            _car = car;
        }

        public void Drive()
        {
            TryDrive();
        }

        public void FillTank()
        {
            Console.WriteLine("Нельзя заправляться на ходу");
        }

        public void Stop()
        {
            _car.SetState(_car.EngineStarted);
            Console.WriteLine("Накатался? Ну постоим...");
        }

        public void TurnKey()
        {
            Console.WriteLine("На ходу ключ не трогать");
        }

        private void TryDrive()
        {
            if (_car.Gasoline > 0)
            {
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
