using System;

namespace Zoolandia.Animals
{
    public class Cat: Animals
    {
        public Cat()
        {
            var Cat = new Animals();
            this.height = "really_tall";
            this.name = "Sylvester";
            this.color = "Purple";
        
        }
          public override void noise ()
        {

            base.noise();
            Console.WriteLine("meow");
        }
    }
}