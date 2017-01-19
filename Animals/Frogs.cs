using System;

namespace Zoolandia.Animals
{
    public class Frog: Animals
    {
        public Frog()
        {
            var Frog = new Animals();
            this.height = "pretty Small";
            this.name = "Kermit";
            this.color = "green";
        
        }
          public override void noise ()
        {

            Console.WriteLine("ribbit");
        }
    }
}