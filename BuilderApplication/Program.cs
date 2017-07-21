using BuilderApplication.Builder;
using BuilderApplication.Factory;
using System;

namespace BuilderApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //we can use buildes directly:
            //var vwBuilder = new VolkswagenBuilder();
            //vwBuilder.BuildFrame();
            //vwBuilder.BuildEngine();
            //vwBuilder.BuildWheels();

            //var car = vwBuilder.GetCar();
            //Console.WriteLine(car);

            //vwBuilder.BuildMultimedia();
            //car = vwBuilder.GetCar();
            //Console.WriteLine(car);

            Console.WriteLine("Cheap VW");
            CarFactoryBase constructor = new CheapCarFactory(new VolkswagenBuilder());
            var car = constructor.Construct();
            Console.WriteLine(car);

            Console.WriteLine("Luxury VW");
            constructor = new LuxuryCarFactory(new VolkswagenBuilder());
            car = constructor.Construct();
            Console.WriteLine(car);

            Console.WriteLine("Cheap Audi");
            constructor = new CheapCarFactory(new AudiBuilder());
            car = constructor.Construct();
            Console.WriteLine(car);

            Console.WriteLine("Luxury Audi");
            constructor = new LuxuryCarFactory(new AudiBuilder());
            car = constructor.Construct();
            Console.WriteLine(car);

            Console.ReadLine();
        }
    }
}
