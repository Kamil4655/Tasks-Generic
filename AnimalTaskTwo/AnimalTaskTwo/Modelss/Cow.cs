using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTaskTwo.Modelss
{
    internal class Cow : Animal
    {
        public Cow(string breed) : base(breed)
        {

        }
        public void ProductMilk()
        {
            Console.WriteLine("milk product");
        }
        public override void EatFood(Food food)
        {
            if(food is Grass)
            {
                Console.WriteLine("Duz Yemek");
            }
            else
            {
                Console.WriteLine("Sehv Yemek");
            }
        }

        public override void MadeSound()
        {
            Console.WriteLine("Inek sesi ohaaa");
        }

    }
}
