using System;

namespace FacadeApplication.WashingMachine
{
    public class Dryer
    {
        public void Dry(int seconds, int intensity)
        {
            Console.WriteLine("Drying {0} seconds with intensity", seconds, intensity);
        }
    }
}
