using System;

namespace Zoolandia.Animals
{
    public class Cat: Animals
    {
        public Cat()
        {
            var Cat = new Animals();
            this.Height = "really_tall";
            this.Name = "Sylvester";
            this.Color = "Purple";
        }
        public override void Noise ()
        {
            base.Noise();
            Console.WriteLine("meow");
        }
        public Cat (string name, int weight)
            {
            this.Name = name;
            this.Weight = weight;
            }

    }
}