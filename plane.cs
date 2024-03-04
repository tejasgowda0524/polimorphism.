using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorphim
{
    internal class plane
    {
        public virtual void fly()
        {
            Console.WriteLine("plane is flying ");
        }

        public void land()
        {
            Console.WriteLine("plane is landing ");
        }

        public void takeoff()
        {
            Console.WriteLine("plane is taking off ");
        }
    }
}
