using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowAndFactoryPattern.Adventurer.Equipments.Weapon
{
    public abstract class Weapon
    {
        protected int atk;

        public void display()
        {
            Console.WriteLine($"atk = {atk} atk");
        }
    }
}
