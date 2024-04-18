using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTaskTwo.Modelss
{
    internal class Meat : Food
    {
        public string Type;
        public Meat(decimal calorie,string type):base(calorie)
        {
            
        }
    }
}
