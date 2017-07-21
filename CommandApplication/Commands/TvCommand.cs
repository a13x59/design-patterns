using CommandApplication.ControlledSystems;

namespace CommandApplication.Commands
{
    public class TvCommand : ICommand
    {
        private Tv _tv;

        public TvCommand(Tv tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.TurnOn();
        }

        public void Undo()
        {
            _tv.TurnOff();
        }

        public override string ToString()
        {
            return "Включить телевизор";
        }
    }
}
