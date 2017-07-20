using DecoratorApplication.Beverage;

namespace DecoratorApplication.Decorators
{
    public class ChocolateCondiment : CondimentsDecoratorBase
    {
        public ChocolateCondiment(BeverageBase beverage)
        {
            _beverage = beverage;
            Description = _beverage.GetDescription() + " +Chocolate";
        }

        public override double GetCost()
        {
            return _beverage.GetCost() + 70;
        }
    }
}
