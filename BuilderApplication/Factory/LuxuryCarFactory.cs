using BuilderApplication.Builder;

namespace BuilderApplication.Factory
{
    public class LuxuryCarFactory : CarFactoryBase
    {
        public LuxuryCarFactory(CarBuilderBase builder) : base(builder)
        {

        }

        public override Car Construct()
        {
            CarBuilder.BuildFrame();
            CarBuilder.BuildEngine();
            CarBuilder.BuildWheels();
            CarBuilder.BuildSafety();
            CarBuilder.BuildMultimedia();
            CarBuilder.BuildLuxury();

            return CarBuilder.GetCar();
        }
    }
}
