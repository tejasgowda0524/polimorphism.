using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorphim
{
    internal class passengerplane: plane
    {
        public override void fly()  // overridden method
        {
            Console.WriteLine("passengerplane is flying at low levels");
        }

        public void carrypassenger()  // specialized method
        {
            Console.WriteLine("passengerplane carry passengers");
        }
    }
}
