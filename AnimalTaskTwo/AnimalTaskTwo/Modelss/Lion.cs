using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTaskTwo.Modelss
{
    internal class Lion : Animal
    {
        public bool IsPrideLeader;
        public Lion(string breed, bool isPrideLeader) : base(breed)
        {
            IsPrideLeader = isPrideLeader;
        }
       
        public override void EatFood(Food food)
        {
            if (food is Meat)
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
            Console.WriteLine("Lion voice");
        }

    }
}
