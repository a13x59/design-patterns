using System;

namespace AdapterApplication.HomeCats
{
    public class PedigreedCat : IHomeCat
    {
        public string Name { get; set; }

        public void Meow()
        {
            Console.WriteLine("Урррр Урррр");
        }

        public void Scratch()
        {
            Console.WriteLine("Я не царапаюсь");
        }
    }
}
