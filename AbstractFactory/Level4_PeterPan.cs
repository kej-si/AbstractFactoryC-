using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Level4_PeterPan : IDisneyFactory
    {
        //this is the concreate factorie
        public IHero CreateHero()
        {
            return new PChildren();
        }

        public IWicked CreateWicked()
        {
            return new PCapHook();
        }

        public IWeapon CreateWeapon()
        {
            return new PSword();
        }
        public IPlace CreatePlace()
        {
            return new PNeverland();
        }

    }
}
