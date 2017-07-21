using System;

namespace CommandApplication.ControlledSystems
{
    public class Tv
    {
        public State State { get; set; }

        public void TurnOn()
        {
            Console.WriteLine("Телевизор включен");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Телевизор выключен");
            State = State.Off;
        }
    }
}
