using System;

namespace Zoolandia.Animals
{
    public class Animals
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Height { get; set; }
        public int Weight { get; set;}
        public string Color { get; set;}

        public virtual void Noise ()
        {
            Console.WriteLine("Zoolandia");

        }
        public virtual void Food ()
        {
            Console.WriteLine("feed me");
        }
        
        

    }
}