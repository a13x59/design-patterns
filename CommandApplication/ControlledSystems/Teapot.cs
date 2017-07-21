using System;

namespace CommandApplication.ControlledSystems
{
    public class Teapot
    {
        public State State { get; set; }

        public void TurnOn()
        {
            Console.WriteLine("Чайник включен");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Чайник выключен");
            State = State.Off;
        }
    }
}
