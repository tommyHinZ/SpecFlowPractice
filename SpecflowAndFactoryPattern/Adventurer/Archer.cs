using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowAndFactoryPattern.Adventurer
{
    public class Archer : Adventurer
    {
        public override String getType()
        {
            Console.WriteLine("I am an archer");
            return "Archer";
        }
    }
}
