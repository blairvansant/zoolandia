using System;

namespace Zoolandia.Animals
{
    public class Dog : Animals
    {
        public Dog()
        {
          var Dog = new Animals();
        
        }
         public override void noise ()
        {
            base.noise();
            Console.WriteLine("woof");
        }
    }
}