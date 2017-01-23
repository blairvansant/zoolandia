using System;

using Zoolandia.Animals;

namespace Zoolandia
 {
     public class Program
     {
          public static void Main(string[] args)
          {
            var OurDog = new Dog();
            OurDog.Name = "Ben";
            OurDog.Species = "Canine";
            OurDog.Height = 23;
            OurDog.Weight = "twenty lb";
            OurDog.Color = "white";   
            OurDog.Sound = "Bark";

            Console.WriteLine($"Our Dog is named {OurDog.Name} and he weighs {OurDog.Weight}.");
            OurDog.Food();
            Console.WriteLine(OurDog.Name);
            Console.WriteLine(OurDog.Height);

            Dog Coyote = new Dog("Coyote");
            Console.WriteLine(Coyote.Name);
            Dog Hyena = new Dog(11);
            Console.WriteLine(Hyena.Height);
            Dog Painted_Dog = new Dog ("whimper");
            Console.WriteLine(Painted_Dog.Sound);



            // var MyCat = new Cat();
            // MyCat.Name = "Sam";
            // MyCat.Species = "Feline";
            // MyCat.Height = 43;
            // MyCat.Weight = 679;
            // MyCat.Color = "black";
            // MyCat.Noise();
            // Cat Sylvester = new Cat();
            // // Console.WriteLine(Sylvester.Height);
            // Console.WriteLine(Sylvester.Color);
            // Console.WriteLine(Sylvester.Name);

            // var MyLizard = new Lizard();
            // MyLizard.Name = "Rocky";
            // MyLizard.Species = "Reptile";
            // MyLizard.Height = 22;
            // MyLizard.Weight = 3;
            // MyLizard.Color = "orange and yellow";
            // Lizard BIGLIZARD = new Lizard();
            // Console.WriteLine(BIGLIZARD.Name);
            // Console.WriteLine(BIGLIZARD.Color);

            // var MyFrog = new Frog();
            // MyFrog.Name = "Chester";
            // MyFrog.Species = "Amphibian";
            // MyFrog.Height = 88;
            // MyFrog.Weight = 202;
            // MyFrog.Color = "brown";
            // MyFrog.Food();
            // MyFrog.Noise(); 
            // Frog Freddy = new Frog();
            // Console.WriteLine(Freddy.Name);
            // Console.WriteLine(Freddy.Color);
            // Console.WriteLine(MyFrog.Name);
            // Console.WriteLine(Freddy.Weight);
            // var BigFrog = new Frog("george", 25);
            // Console.WriteLine(BigFrog.Weight);
            // Console.WriteLine(BigFrog.Name);
            // Console.WriteLine(BigFrog.Species);


            
          
                // Console.WriteLine ($"I have a dog named {MyDog.Name} and an {MyLizard.Color} leopard gecko named {MyLizard.Name}. I used to have a {MyCat.Color} cat named {MyCat.Name}.");
          
          }


      }

}
