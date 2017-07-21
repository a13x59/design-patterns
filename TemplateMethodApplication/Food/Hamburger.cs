using System;

namespace TemplateMethodApplication.Food
{
    public class Hamburger : FastFood
    {
        protected override void PrepareMainIngredien()
        {
            Console.WriteLine("Meat");
        }

        protected override void AddTopings()
        {
            Console.WriteLine("Ketchup");
        }
    }
}
