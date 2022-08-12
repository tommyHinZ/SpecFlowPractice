using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecflowAndFactoryPattern.Adventurer.Equipments.Armour;
using SpecflowAndFactoryPattern.Adventurer.Equipments.Weapon;

namespace SpecflowAndFactoryPattern.Adventurer.Factory.EquipmentFactory
{
    public interface IEquipmentFactory
    {
        Weapon productWeapon();
        Armour productArmour();
    }
}
