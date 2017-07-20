using DecoratorApplication.Beverage;

namespace DecoratorApplication.Decorators
{
    public class SugarCondiment : CondimentsDecoratorBase
    {
        public SugarCondiment(BeverageBase beverage)
        {
            _beverage = beverage;
            Description = _beverage.GetDescription() + " +Sugar";
        }

        public override double GetCost()
        {
            return _beverage.GetCost() + 10;
        }
    }
}
