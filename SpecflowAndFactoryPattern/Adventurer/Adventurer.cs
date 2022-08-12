using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecflowAndFactoryPattern.Adventurer.Equipments.Armour;
using SpecflowAndFactoryPattern.Adventurer.Equipments.Weapon;

namespace SpecflowAndFactoryPattern.Adventurer
{
    public abstract class Adventurer
    {
        protected Weapon weapon;
        protected Armour armour;

        public String getWeapon()
        {
            weapon.display();
        }

        public void setWeapon(Weapon w)
        {
            weapon = w;
        }

        public String getArmour()
        {
            armour.display();
        }

        public void setArmour(Armour a)
        {
            armour = a;
        }

        public abstract String getType();
    }
}
