using System;

namespace TemplateMethodApplication.Food
{
    public class HotDog : FastFood
    {
        protected override bool CustomerWantsTopingd()
        {
            Console.WriteLine("Do you want mustard?: ");
            var userInput = Console.ReadLine();

            return userInput.ToLower() == "yes" || userInput.ToLower() == "y";
        }

        protected override void PrepareMainIngredien()
        {
            Console.WriteLine("Sausage");
        }

        protected override void AddTopings()
        {
            Console.WriteLine("Mustard");
        }
    }
}
