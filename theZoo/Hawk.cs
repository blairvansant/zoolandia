using System;

namespace Zoolandia.Animals
{
    public class Hawk: Carnivores
    {
        string firstName = "Red Tailed Hawk";
        string scientinficName = "butejo jamaicensis";

        public override void Food()
        {
            Console.WriteLine("Vermin");
        }
        // public void AboutDiet()
        // {
        //     Console.WriteLine("Yay, Peanuts !");
        // }
    }
}