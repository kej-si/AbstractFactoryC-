using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Level3_WallE : IDisneyFactory
    {
        //this is the concreate factorie
        public IHero CreateHero()
        {
            return new WWallE();
        }

        public IWicked CreateWicked()
        {
            return new WTrash();
        }

        public IWeapon CreateWeapon()
        {
            return new WRecycle();
        }
        public IPlace CreatePlace()
        {
            return new WEarth();
        }

    }
}