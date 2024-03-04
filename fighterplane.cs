using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorphim
{
    internal class fighterplane : plane
    {
        public override void fly()  // overridden method
        {
            Console.WriteLine("fighterplane is flying at high levels");
        }

        public void carryweapons()  // specialized method
        {
            Console.WriteLine("fighterplane carry weapons");
        }
    }
}
