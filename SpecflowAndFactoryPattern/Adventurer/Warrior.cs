using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowAndFactoryPattern.Adventurer
{
    public class Warrior : Adventurer
    {
        public override String getType()
        {
            Console.WriteLine("I am a warrior!");
            return "Warrior";
        }
    }
}
