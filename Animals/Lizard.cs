using System;

namespace Zoolandia.Animals
{
    public class Lizard: Animals
    {
        public Lizard()
        {
        var Lizard = new Animals();
        this.Name = "BIGLIZARD";
        this.Color = "rainbow";
        
        }
        public override void Noise ()
        {
            base.Noise();
            Console.WriteLine("no sound");
        }
        public Lizard (string name, int weight)
            {
            this.Name = name;
            this.Weight = weight;
            }

    }
}