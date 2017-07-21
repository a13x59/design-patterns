using AdapterApplication.HomeCats;
using System;

namespace AdapterApplication
{
    public class CatInfoPrinter
    {
        public static void PrintCatInfo(IHomeCat cat)
        {
            Console.WriteLine("Кошачье досье:");
            Console.WriteLine("Имя кота: {0}", cat.Name);

            Console.Write("Вид мяуканья: ");
            cat.Meow();
            Console.Write("Вид царапанья: ");
            cat.Scratch();

            Console.WriteLine();
        }
    }
}
