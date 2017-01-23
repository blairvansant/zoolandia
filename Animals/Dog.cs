using System;

namespace Zoolandia.Animals
{
    public class Dog : Animals
    {
        public Dog()
        {
          this.Name = "new dog";        
        }
        public Dog(string Name)
         {
          base.Name = Name;
        }
        public Dog(int Height)
        {
          this.Height = Height;
        }
        public Dog(string Name, int Height)
        {
          this.Name = Name;
          this.Height = Height;
        }
         public  override void Food ()
        {
            Console.WriteLine("Yes please!!!");
        }

    }
}