using System;

namespace Zoolandia.Animals
{
    public class Frog: Animals
    {
        public Frog()
        {
            var Frog = new Animals();
            this.Height = "pretty Small";
            this.Name = "Kermit";
            this.Color = "green";
            this.Weight = 4545;
        
        }
        public override void Noise ()
        {
            // base.noise();
            Console.WriteLine("ribbit");
        }
        public override void Food ()
        {
            // base.Food();
            Console.WriteLine("flies");
        }
         public Frog (string name, int weight)
            {
              this.Name = name;
              this.Weight = weight;
            }

    }
}




