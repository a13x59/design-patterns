namespace StateApplication.States
{
    public interface IState
    {
        void FillTank();
        void TurnKey();
        void Drive();
        void Stop();
    }
}
