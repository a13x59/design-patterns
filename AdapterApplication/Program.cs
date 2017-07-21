using AdapterApplication.Adapters;
using AdapterApplication.HomeCats;
using AdapterApplication.WildCats;
using System;

namespace AdapterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IHomeCat vaska = new YardCat();
            vaska.Name = "Васька";
            CatInfoPrinter.PrintCatInfo(vaska);

            IHomeCat wagner = new PedigreedCat();
            wagner.Name = "Вагнер";
            CatInfoPrinter.PrintCatInfo(wagner);

            IWildCat tiger = new Tiger();
            HomeCatAdapter adapter = new HomeCatAdapter(tiger);
            CatInfoPrinter.PrintCatInfo(adapter);

            Console.ReadLine();
        }
    }
}
