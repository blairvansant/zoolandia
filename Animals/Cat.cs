using System;

namespace Zoolandia.Animals
{
    public class Cat: Animals
    {
        public Cat()
        {
            var Cat = new Animals();
            this.Height = 89;
            this.Name = "Sylvester";
            this.Color = "Purple";
        }

        // public  void Noise (string noise)
        // {    
        // //  base.Noise("the cat purrs");

        // }
        // public Cat (string name, int weight)
        //     {
        //     this.Name = name;
        //     this.Weight = weight;
        //     }

    }
}