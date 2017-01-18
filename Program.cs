using System;

using Zoolandia.Animals;

namespace Zoolandia
 {
     public class Program
     {
          public static void Main(string[] args)
          {
            var MyDog = new Dog();
            MyDog.name = "Ben";
            MyDog.species = "Canine";
            MyDog.height = "not too big";
            MyDog.weight = "30 lb";
            MyDog.color = "white";
            MyDog.noise();

            var MyCat = new Cat();
            MyCat.name = "Sam";
            MyCat.species = "Feline";
            MyCat.height = "pretty small";
            MyCat.weight = "8 lb";
            MyCat.color = "black";
            MyCat.noise();

            var MyLizard = new Lizard();
            MyLizard.name = "Rocky";
            MyLizard.species = "Reptile";
            MyLizard.height = "1 inch";
            MyLizard.weight = "3 oz";
            MyLizard.color = "orange and yellow";
            MyLizard.noise();  
          
                Console.WriteLine ($"I have a dog named {MyDog.name} and an {MyLizard.color} leopard gecko named {MyLizard.name}. I used to have a {MyCat.color} cat named {MyCat.name}.");

          
          }


      }

}
