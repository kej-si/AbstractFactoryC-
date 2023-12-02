using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AGhost : IWeapon
    {
        //concrete product
        public void TheDeathWeapon()
        {
            Console.WriteLine("Rasputin is kinda dead and he has ghost magical power");
        }
    }
}
