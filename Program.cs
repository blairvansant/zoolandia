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


            var MyCat = new Cat();
            MyCat.Name = "Sam";
            MyCat.Species = "Feline";
            MyCat.Height = 43;
            MyCat.Weight = "great";
            MyCat.Color = "black";
            Cat Sylvester = new Cat();
            // Console.WriteLine(Sylvester.Height);
            // Console.WriteLine(Sylvester.Color);
            // Console.WriteLine(Sylvester.Name);


            var MyLizard = new Lizard();
            MyLizard.Name = "Rocky";
            MyLizard.Species = "Reptile";
            MyLizard.Height = 09;
            MyLizard.Weight = "2 0z";
            MyLizard.Color = "orange and yellow";
            MyLizard.Sound = "None";

            // Console.WriteLine($"Our Lizard is named {MyLizard.Name} and he weighs {MyLizard.Weight}.");
            // MyLizard.Food();
            // Console.WriteLine(MyLizard.Name);
            // Console.WriteLine(MyLizard.Height);

            Lizard Komodo = new Lizard("Komodo");
            Console.WriteLine(Komodo.Name);
            Lizard Chameleon = new Lizard(34);  
            Console.WriteLine(Chameleon.Height);
            Lizard Anole = new Lizard ("shutup");
            Console.WriteLine(Anole.Sound);
         

            var MyFrog = new Frog();
            MyFrog.Name = "Kermit";
            MyFrog.Species = "Amphibian";
            MyFrog.Height = 88;
            MyFrog.Weight = "FAT";
            MyFrog.Color = "brown";
            MyFrog.Food();

            // Console.WriteLine($"Our Frog is named {MyFrog.Name} and he weighs {MyFrog.Weight}.");
            // Console.WriteLine(MyFrog.Name);
            // Console.WriteLine(MyFrog.Height);

            Frog Toad = new Frog("fast frog");
            Console.WriteLine(Toad.Name);
            Frog Tadpole = new Frog("Green");
            Console.WriteLine(Tadpole.Color);
            Frog MrKermit = new Frog("Frail");
            Console.WriteLine(MrKermit.Weight);

            // zoo 

            // Herbivore
            Elephant elephant = new Elephant();
            elephant.AboutDiet();
            elephant.Food();
     
            // Carnivore
            Hawk hawk = new Hawk();
            hawk.AboutDiet();
            hawk.Food();

            // Herbivore
            Tortoise tortoise = new Tortoise();
            tortoise.AboutDiet();
            tortoise.Food();

            // Herbivore
            Kudu kudu = new Kudu();
            kudu.AboutDiet();
            kudu.Food();
        

            // Carnivore
            Tiger tiger = new Tiger();
            tiger.AboutDiet();
            tiger.Food();

            // Herbivore
            Kangaroo kangaroo = new Kangaroo();
            kangaroo.AboutDiet();
            kangaroo.Food();
          }


      }

}
