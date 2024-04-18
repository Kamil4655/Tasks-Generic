using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTaskTwo.Modelss
{
    internal class Grass : Food
    {
        public string Name;
        public Grass(decimal calorie, string name) : base(calorie)
        {
            Name = name;
        }
    }
}
