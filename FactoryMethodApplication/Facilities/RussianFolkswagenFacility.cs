using FactoryMethodApplication.Cars;

namespace FactoryMethodApplication.Facilities
{
    public class RussianFolkswagenFacility : VolkswagenFacility
    {
        protected override Car CreateCar(string type)
        {
            Car car = null;

            if (type == "Golf")
                car = new RussianGolf();
            else if (type == "Passat")
                car = new RussianPassat();
            else if (type == "Tiguan")
                car = new RussianTiguan();
            else if (type == "Touareg")
                car = new RussianTouareg();

            return car;
        }
    }
}
