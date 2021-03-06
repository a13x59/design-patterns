﻿using FactoryApplication.Cars;
using FactoryApplication.PartsFactory;

namespace FactoryApplication.Facilities
{
    public class DeutschVolkswagenFacility : VolkswagenFacility
    {
        protected override Car CreateCar(string type)
        {
            Car car = null;
            CarPartsFactory factory = new DeutschCarPartsFactory();

            if (type == "Golf")
                car = new Golf(factory);
            else if (type == "Passat")
                car = new Passat(factory);
            else if (type == "Tiguan")
                car = new Tiguan(factory);
            else if (type == "Touareg")
                car = new Touareg(factory);

            return car;
        }
    }
}
