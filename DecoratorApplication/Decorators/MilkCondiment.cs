using DecoratorApplication.Beverage;

namespace DecoratorApplication.Decorators
{
    public class MilkCondiment : CondimentsDecoratorBase
    {
        public MilkCondiment(BeverageBase beverage)
        {
            _beverage = beverage;
            Description = _beverage.GetDescription() + " +Milk";
        }

        public override double GetCost()
        {
            return _beverage.GetCost() + 50;
        }
    }
}
