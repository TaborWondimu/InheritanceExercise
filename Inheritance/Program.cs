using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird bird = new Bird();

            bird.BreedType = "Dove";
            bird.IsMammal = true;
            bird.CanFly = true;
            bird.Gender = "female";
            bird.Habitat = "tree";

            /*Create an object of your Reptile class
              *  give values to your members using the object of your Reptile class
              *  
              * Creatively display the class member values 
              */
            Reptile reptile = new Reptile()
            {
                Name = "Snake",
                IsPet = true,
                LivesOnLand = true,
                Crawls = true,
            };

            var animalList = new Animal[] {bird};    
            foreach(var animal in animalList)
            {
                Console.WriteLine($"Can Fly? {bird.CanFly}");
                Console.WriteLine($"Lives on {bird.Habitat}");
                Console.WriteLine($"Gender Is {bird.Gender}"); 
                Console.WriteLine($"Mammal? {bird.IsMammal} ");
                Console.WriteLine($"Breed Type {bird.BreedType}");
            }
           

        }
    }
}

