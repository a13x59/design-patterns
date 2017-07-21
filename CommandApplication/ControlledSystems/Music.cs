using System;

namespace CommandApplication.ControlledSystems
{
    public class Music
    {
        public State State { get; set; }

        public void TurnOn()
        {
            Console.WriteLine("Музыка включена");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Музыка выключена");
            State = State.Off;
        }
    }
}
