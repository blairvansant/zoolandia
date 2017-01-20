using System;

using Zoolandia.Animals;

namespace Zoolandia
 {
     public class Program
     {
          public static void Main(string[] args)
          {
            var MyDog = new Dog();
            MyDog.Name = "Ben";
            MyDog.Species = "Canine";
            MyDog.Height = "not too big";
            MyDog.Weight = 19099090;
            MyDog.Color = "white";
            // MyDog.Noise();
            // Dog giantDog = new Dog();
            // Console.WriteLine(giantDog.Name);
            // Console.WriteLine(giantDog.Color);

            var MyCat = new Cat();
            MyCat.Name = "Sam";
            MyCat.Species = "Feline";
            MyCat.Height = "pretty small";
            MyCat.Weight = 679;
            MyCat.Color = "black";
            // MyCat.Noise();
            // Cat Sylvester = new Cat();
            // // Console.WriteLine(Sylvester.Height);
            // Console.WriteLine(Sylvester.Color);
            // Console.WriteLine(Sylvester.Name);

            var MyLizard = new Lizard();
            MyLizard.Name = "Rocky";
            MyLizard.Species = "Reptile";
            MyLizard.Height = "1 inch";
            MyLizard.Weight = 3;
            MyLizard.Color = "orange and yellow";
            // MyLizard.Noise(); 
            // Lizard BIGLIZARD = new Lizard();
            // Console.WriteLine(BIGLIZARD.Name);
            // Console.WriteLine(BIGLIZARD.Color);

            var MyFrog = new Frog();
            MyFrog.Name = "Chester";
            MyFrog.Species = "Amphibian";
            MyFrog.Height = "66.88";
            MyFrog.Weight = 202;
            MyFrog.Color = "brown";
            MyFrog.Food();
            MyFrog.Noise(); 
            Frog Freddy = new Frog();
            Console.WriteLine(Freddy.Name);
            Console.WriteLine(Freddy.Color);
            Console.WriteLine(MyFrog.Name);
            Console.WriteLine(Freddy.Weight);
            var BigFrog = new Frog("george", 25);
            Console.WriteLine(BigFrog.Weight);
            Console.WriteLine(BigFrog.Name);


            
          
                Console.WriteLine ($"I have a dog named {MyDog.Name} and an {MyLizard.Color} leopard gecko named {MyLizard.Name}. I used to have a {MyCat.Color} cat named {MyCat.Name}.");
                Console.WriteLine($"My old frog {Freddy.Name} died. I got a new one named {BigFrog.Name}. {BigFrog.Name} eats");
          
          }


      }

}
