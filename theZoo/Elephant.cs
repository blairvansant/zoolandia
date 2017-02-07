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
         public void AboutDiet()
        {
            Console.WriteLine("Yay, Peanuts !");
        }
        
    }
}