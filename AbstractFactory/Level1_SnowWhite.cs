using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Level1_SnowWhite : IDisneyFactory
    {
        //this is the concreate factorie
        public IHero CreateHero()
        {
            return new SDwarfs();
        }

        public IWicked CreateWicked()
        {
            return new SStepmom();
        }

        public IWeapon CreateWeapon()
        {
            return new SPoisonedApple();
        }
        public IPlace CreatePlace()
        {
            return new SDwarfsHouse();
        }

    }
}
