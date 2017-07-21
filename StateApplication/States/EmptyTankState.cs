using System;

namespace StateApplication.States
{
    public class EmptyTankState : IState
    {
        private readonly Car _car;

        public EmptyTankState(Car car)
        {
            _car = car;
        }

        public void Drive()
        {
            Console.WriteLine("И как мы поедем без бензина? Никак!");
        }

        public void FillTank()
        {
            _car.SetState(_car.FullTank);
            Console.WriteLine("Теперь бак полный");
        }

        public void Stop()
        {
            Console.WriteLine("Нет бензина - значит итак стоим");
        }

        public void TurnKey()
        {
            Console.WriteLine("Без бензина не работаю");
        }
    }
}
