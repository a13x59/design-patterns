namespace BuilderApplication.Builder
{
    public abstract class CarBuilderBase
    {
        protected Car Car;

        public CarBuilderBase()
        {
            Car = new Car();
        }

        public Car GetCar()
        {
            return Car;
        }

        public abstract void BuildEngine();
        public abstract void BuildFrame();
        public abstract void BuildWheels();
        public abstract void BuildLuxury();
        public abstract void BuildMultimedia();
        public abstract void BuildSafety();
    }
}
