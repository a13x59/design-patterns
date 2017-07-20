using FactoryMethodApplication.Cars;

namespace FactoryMethodApplication.Facilities
{
    public class DeutschVolkswagenFacility : VolkswagenFacility
    {
        protected override Car CreateCar(string type)
        {
            Car car = null;

            if (type == "Golf")
                car = new DeutschGolf();
            else if (type == "Passat")
                car = new DeutschPassat();
            else if (type == "Tiguan")
                car = new DeutschTiguan();
            else if (type == "Touareg")
                car = new DeutschTouareg();

            return car;
        }
    }
}
