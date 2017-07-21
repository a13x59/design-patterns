using System;

namespace TemplateMethodApplication.Food
{
    public abstract class FastFood
    {
        public void Prepare()
        {
            RoastBread();
            PrepareMainIngredien();
            PutVegatables();

            if (CustomerWantsTopingd())
                AddTopings();
        }

        protected void PutVegatables()
        {
            Console.WriteLine("Vegatables");
        }

        protected void RoastBread()
        {
            Console.WriteLine("Bread");
        }

        protected abstract void PrepareMainIngredien();

        protected abstract void AddTopings();

        protected virtual bool CustomerWantsTopingd()
        {
            return true;
        }
    }
}
