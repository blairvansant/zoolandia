using System;

namespace Zoolandia.Animals
{
    public class Cat: Animals
    {
        public Cat()
        {
            var Cat = new Animals();
        
        }
          public override void noise ()
        {
            base.noise();
            Console.WriteLine("meow");
        }
    }
}