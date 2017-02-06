using System;

namespace Zoolandia.Animals
{
    public class Herbivores : Animals
    {
        public virtual void AboutDiet()
        {
            Console.WriteLine("Does not eat meat.");
        }
    }
}