using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTaskTwo.Modelss
{
    abstract class Food
    {
        public decimal Calorie;
        protected Food(decimal calorie)
        {
            Calorie = calorie;
        }
    }
}
