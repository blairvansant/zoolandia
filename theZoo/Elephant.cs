using System;

namespace Zoolandia.Animals
{
    public class Elephant: Herbivores
    {
        string firstName = "Dumbo";
        string scientinficName = "Loxodonta";

        public override void Food()
        {
            Console.WriteLine("Peanuts");
        }
        public override void aboutDiet()
        {
            Console.WriteLine("Yay, Peanuts !");
        }
    }
}