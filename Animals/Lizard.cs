using System;

namespace Zoolandia.Animals
{
    public class Lizard: Animals
    {
        public Lizard()
        {
        var Lizard = new Animals();
        this.name = "BIGLIZARD";
        this.color = "rainbow";
        
        }
          public override void noise ()
        {
            Console.WriteLine("no sound");
        }
    }
}