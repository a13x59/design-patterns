using BuilderApplication.Builder;

namespace BuilderApplication.Factory
{
    public class CheapCarFactory : CarFactoryBase
    {
        public CheapCarFactory(CarBuilderBase builder) : base(builder)
        {

        }

        public override Car Construct()
        {
            CarBuilder.BuildFrame();
            CarBuilder.BuildEngine();
            CarBuilder.BuildWheels();
            CarBuilder.BuildSafety();

            return CarBuilder.GetCar();
        }
    }
}
