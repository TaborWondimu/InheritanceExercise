using System;

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

            Console.WriteLine($"Quick Facts About My Bird \n Breed is {bird.BreedType} \n Bird Mammal? {bird.IsMammal}\n Can it fly? {bird.CanFly}\n My Bird resides on {bird.Habitat}\n My bird is {bird.Gender}");
            

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile reptile = new Reptile();
            reptile.Name = "Snake";
            reptile.IsPet = true;
            reptile.LivesOnLand = true;
            reptile.Crawls = true;
            Console.WriteLine($"==========================================================");

            Console.WriteLine($"Missing Reptile\nName is {reptile.Name}\nIf you ask is it a pet? the answer is {reptile.IsPet}\nIf you are still curious and ask does it live on land?\nYes that is {reptile.LivesOnLand}\nYou don't believe me so you ask me does it crawl?\n the answer is {reptile.Crawls} ");

        }
    }
}
