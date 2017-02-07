using System;

namespace Zoolandia.Animals
{
    public class Tiger: Carnivores
    {
        public string firstName = "Tony the Tiger";
        string scientinficName = "Panthera tigris";

        public override void Food()
        {
            Console.WriteLine("Kudu!");
        }
        public void AboutDiet()
        {
            Console.WriteLine("Yay, Kudu !");
        }
    }
}