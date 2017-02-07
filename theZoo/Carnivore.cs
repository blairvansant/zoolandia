using System;

namespace Zoolandia.Animals
{
    public class Carnivores : Animals
    {
        public virtual void AboutDiet()
        {
            Console.WriteLine("Loves to eat meat.");
        }
    }
}