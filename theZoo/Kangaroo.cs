using System;

namespace Zoolandia.Animals
{
    public class Kangaroo: Herbivores
    {
        string firstName = "Cool Dude Kangaroo";
        string scientinficName = "Macropus rufus";

        public override void Food()
        {
            Console.WriteLine("Little grasses");
        }
        // public void AboutDiet()
        // {
        //     Console.WriteLine("Yay, Grass");
        // }
    }
}