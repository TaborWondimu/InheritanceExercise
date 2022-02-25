using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {
            // default constructor
        }
        public int NumofLegs{ get; set; }
        public string Name{ get; set; }
        public bool IsMammal{ get; set; }
        public bool IsDomestic{ get; set; }
    }
    public class Bird : Animal
    {
        public Bird()
        {
         // defaul constructor
        }
        public string Gender{ get; set; }
        public string BreedType{ get; set; }
        public string Habitat{ get; set; }
        public bool CanFly{ get; set; }
    }
    public class Reptile : Animal
    {
        public Reptile()
        {
            // default constructor 
        }
        public bool Crawls{ get; set;}
        public bool IsPet{ get; set;}
        public string Name { get; set;}
        public bool LivesOnLand { get; set;}
    }

}
