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
            Dog giantDog = new Dog();
            Console.WriteLine(giantDog.name);
            Console.WriteLine(giantDog.color);

            var MyCat = new Cat();
            MyCat.name = "Sam";
            MyCat.species = "Feline";
            MyCat.height = "pretty small";
            MyCat.weight = "8 lb";
            MyCat.color = "black";
            MyCat.noise();
            Cat Sylvester = new Cat();
            Console.WriteLine(Sylvester.height);
            Console.WriteLine(Sylvester.color);
            Console.WriteLine(Sylvester.name);

            var MyLizard = new Lizard();
            MyLizard.name = "Rocky";
            MyLizard.species = "Reptile";
            MyLizard.height = "1 inch";
            MyLizard.weight = "3 oz";
            MyLizard.color = "orange and yellow";
            MyLizard.noise(); 
            Lizard BIGLIZARD = new Lizard();
            Console.WriteLine(BIGLIZARD.name);
            Console.WriteLine(BIGLIZARD.color);

            var MyFrog = new Frog();
            MyLizard.name = "Chester";
            MyLizard.species = "Amphibian";
            MyLizard.height = "3\"";
            MyLizard.weight = "15 oz";
            MyLizard.color = "brown";
            MyLizard.noise(); 
            Frog Freddy = new Frog();
            Console.WriteLine(Freddy.name);
            Console.WriteLine(Freddy.color);

            
          
                Console.WriteLine ($"I have a dog named {MyDog.name} and an {MyLizard.color} leopard gecko named {MyLizard.name}. I used to have a {MyCat.color} cat named {MyCat.name}.");

          
          }


      }

}
