using FactoryApplication.Facilities;
using System;

namespace FactoryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //VolkswagenFacility facility = new RussianFolkswagenFacility();
            VolkswagenFacility facility = new DeutschVolkswagenFacility();

            facility.GetCar("Golf");
            Console.WriteLine();

            facility.GetCar("Passat");
            Console.WriteLine();

            facility.GetCar("Tiguan");
            Console.WriteLine();

            facility.GetCar("Touareg");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
