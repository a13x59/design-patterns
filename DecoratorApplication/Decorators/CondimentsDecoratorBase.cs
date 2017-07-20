using DecoratorApplication.Beverage;

namespace DecoratorApplication.Decorators
{
    public abstract class CondimentsDecoratorBase : BeverageBase
    {
        protected BeverageBase _beverage;
    }
}
