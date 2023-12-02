using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Level2_Anastasia : IDisneyFactory
    {
        //this is another concrete factorie
        public IHero CreateHero()
        {
            return new ADimitri();
        }

        public IWicked CreateWicked()
        {
            return new ARasputin();
        }

        public IWeapon CreateWeapon()
        {
            return new AGhost();
        }
        public IPlace CreatePlace()
        {
            return new APonteAlexandreIII();
        }

    }
}