using System;

namespace Zoolandia.Animals
{
    public class Cat: Animals
    {
         public Cat()
        {
          this.Name = "Garfield";        
        }
        public Cat(string Name)
         {
          base.Name = Name;
        }
        public Cat(int Height)
        {
          this.Height = Height;
        }
        public Cat(string Name, int Height)
        {
          this.Name = Name;
          this.Height = Height;
        }

    }
}