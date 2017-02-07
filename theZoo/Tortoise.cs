using System;

namespace Zoolandia.Animals
{
    public class Tortoise: Herbivores
    {
        string firstName = "Tommy Turtle";
        string scientinficName = "Testudinidae";

        public override void Food()
        {
            Console.WriteLine("Cabbage");
        }
        public void AboutDiet()
        {
            Console.WriteLine("Yay, Cabbage");
        }
    }
}