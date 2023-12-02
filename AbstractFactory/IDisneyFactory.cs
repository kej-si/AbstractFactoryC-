using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{ 
    public interface IDisneyFactory
    {
    //this is the abstract factory, the interface where I declared the 
        IHero CreateHero();
        IWicked CreateWicked();
        IWeapon CreateWeapon();
        IPlace CreatePlace();
    }
}
