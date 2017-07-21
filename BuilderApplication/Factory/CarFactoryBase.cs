using BuilderApplication.Builder;

namespace BuilderApplication.Factory
{
    public abstract class CarFactoryBase
    {
        protected readonly CarBuilderBase CarBuilder;

        protected CarFactoryBase(CarBuilderBase builder)
        {
            CarBuilder = builder;
        }

        public abstract Car Construct();
    }
}
