using System;

namespace Zoolandia.Animals
{
    public class Lizard: Animals
    {
        public Lizard()
        {
            this.Name = "Charmander";
        }
        public Lizard(string Name)
        {
            base.Name = Name;
        }
        public Lizard(int Height)
        {
            this.Height = Height;
        }
        public Lizard(string Species, int Height)
        {
            this.Species = Species;
            this.Height = Height;
        }
       

    }
}