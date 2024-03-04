using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorphim
{
    internal class airport
    {
        public static void permit(plane p)
        {
            p.fly();
            p.takeoff();
            p.land();
        }
    }
}
