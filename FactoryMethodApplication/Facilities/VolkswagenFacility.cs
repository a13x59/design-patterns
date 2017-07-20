using FactoryMethodApplication.Cars;

namespace FactoryMethodApplication.Facilities
{
    public abstract class VolkswagenFacility
    {
        public Car GetCar(string type)
        {
            Car car = CreateCar(type);

            car.Configure();
            car.AssemblyBody();
            car.InstallEngine();
            car.Paint();
            car.InstallWheels();

            return car;
        }

        protected abstract Car CreateCar(string type);//This is Factory Method
    }
}
