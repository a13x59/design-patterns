namespace CommandApplication.Commands
{
    public interface ICommand
    {
        void Execute();

        void Undo();

        //IResponse Execute(IRequest req) todo - if required some protocol
    }
}
