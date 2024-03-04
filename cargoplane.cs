using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorphim
{
    internal class cargoplane :plane
    {
         public override void fly()  // overridden method
    {
        Console.WriteLine("cargoplane is flying at medium levels");
    }

    public void carrycargo()    // specialized method
    {
        Console.WriteLine("cargoplane carry cargo");
    }
    }
}
