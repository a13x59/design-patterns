using FacadeApplication.WashingMachine;
using System;

namespace FacadeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var water = new WaterManagingSubsystem();
            var thermo = new Thermo();
            var engine = new Engine();
            var dryer = new Dryer();

            var washingMachine = new WashingMachine.WashingMachine(dryer, engine, thermo, water);

            Console.WriteLine("Cotton");
            washingMachine.WashCotton();

            Console.WriteLine("Wool");
            washingMachine.WashWool();

            Console.ReadLine();
        }
    }
}
