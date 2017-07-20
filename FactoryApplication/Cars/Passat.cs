using FactoryApplication.PartsFactory;
using System;

namespace FactoryApplication.Cars
{
    public class Passat : Car
    {
        private CarPartsFactory _factory;

        public Passat(CarPartsFactory factory)
        {
            Name = "Passat";
            Body = "Sedan";
            _factory = factory;
        }

        public override void Configure()
        {
            Console.WriteLine("Configuring {0}", Name);
            Console.WriteLine("Body is: {0}", Body);

            Engine = _factory.CreateEngine();
            PaintColor = _factory.CreatePaint();
            Wheels = _factory.CreateWheels();
        }
    }
}
