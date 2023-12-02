using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Level5_Mulan : IDisneyFactory
    {
        //this is the concreate factorie
        public IHero CreateHero()
        {
            return new MMulan();
        }

        public IWicked CreateWicked()
        {
            return new MHunArmy();
        }

        public IWeapon CreateWeapon()
        {
            return new MKarate();
        }
        public IPlace CreatePlace()
        {
            return new MChina();
        }

    }
}