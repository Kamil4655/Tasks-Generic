using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTaskTwo.Modelss
{
    abstract class Animal
    {
        public string Breed;
        public abstract void MadeSound();
        public abstract void EatFood(Food food);
        public Animal(string breed)
        {
            Breed = breed;
        }
    }
}
