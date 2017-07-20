using DecoratorApplication.Beverage;
using DecoratorApplication.Decorators;
using System;

namespace DecoratorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageBase espresso = new Espresso();
            BeverageBase blackTea = new BlackTea();
            BeverageBase greenTea = new GreenTea();

            PrintBaverage(espresso);
            PrintBaverage(blackTea);
            PrintBaverage(greenTea);

            Console.WriteLine("------------");

            BeverageBase capuccino = new SugarCondiment(new MilkCondiment(new Espresso()));
            PrintBaverage(capuccino);

            BeverageBase greenTeaWithSugar = new SugarCondiment(new GreenTea());
            PrintBaverage(greenTeaWithSugar);

            Console.WriteLine();
        }

        private static void PrintBaverage(BeverageBase beverage)
        {
            Console.WriteLine("Beverage: {0}; Price: {1}", beverage.GetDescription(), beverage.GetCost());
        }
    }
}
