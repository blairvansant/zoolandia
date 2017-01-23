using System;

namespace Zoolandia.Animals
{
    public class Animals
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Height { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
        public string Sound  { get; set; }

        public virtual void Food()
        {
            Console.WriteLine("feed me");
        }


    
        
        

    }
}