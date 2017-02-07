using System;

namespace Zoolandia.Animals
{
    public class Kudu: Herbivores
    {
        string firstName = "Cool Dude Kudu";
        string scientinficName = "Testudinidae";

        public override void Food()
        {
            Console.WriteLine("Grass");
        }
        // public void AboutDiet()
        // {
        //     Console.WriteLine("Yay, Grass");
        // }
    }
}