using System;

namespace Zoolandia.Animals
{
    public class Frog: Animals
    {
        public Frog()
        {
          this.Name = "Bull Frog";        
        }
        public Frog(string Name)
         {
          base.Name = Name;
        }
        public Frog(int Height)
        {
          this.Height = Height;
        }
        public Frog(string Name, int Height)
        {
          this.Name = Name;
          this.Height = Height;
        }
 

    }
}




