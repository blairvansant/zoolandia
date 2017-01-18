using System;

namespace Zoolandia.Animals
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

            var MyCat = new Cat();
            MyCat.name = "Sam";
            MyCat.species = "Feline";
            MyCat.height = "pretty small";
            MyCat.weight = "8 lb";
            MyCat.color = "black";

            var MyLizard = new Lizard();
            MyLizard.name = "Rocky";
            MyLizard.species = "Reptilia";
            MyLizard.height = "1 inch";
            MyLizard.weight = "3 oz";
            MyLizard.color = "orange and yellow";
          
                      Console.WriteLine ($"I have a dog named {MyDog.name} ");

          
          }


      }

}
