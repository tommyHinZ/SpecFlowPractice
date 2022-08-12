using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowAndFactoryPattern.Adventurer.Equipments.Armour
{
    public abstract class Armour
    {
        protected int def;

        public void display()
        {
            Console.WriteLine($"def = {def} def");
        }
    }
}
