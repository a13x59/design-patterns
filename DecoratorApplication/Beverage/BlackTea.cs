namespace DecoratorApplication.Beverage
{
    class BlackTea : BeverageBase
    {
        public BlackTea()
        {
            Description = "Black tea from teabag";
        }

        public override double GetCost()
        {
            return 25;
        }
    }
}
