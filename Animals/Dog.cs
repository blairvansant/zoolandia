using System;

namespace Zoolandia.Animals
{
    public class Dog : Animals
    {
        public Dog()
        {
          var Dog = new Animals();
          this.Name = "our dog";
        
        }
         public override void Noise ()
        {
            base.Noise();
            Console.WriteLine("woof");
        }
          public Dog (string name, int weight)
            {
              this.Name = name;
              this.Weight = weight;
            }

    }
}