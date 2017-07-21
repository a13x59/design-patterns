using System;

namespace AdapterApplication.HomeCats
{
    public class YardCat : IHomeCat
    {
        public string Name { get; set; }

        public void Meow()
        {
            Console.WriteLine("Мяу мяу!");
        }

        public void Scratch()
        {
            Console.WriteLine("Я царапаюсь но не сильно");
        }
    }
}
