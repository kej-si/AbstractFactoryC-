using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the villan specific to Anastasia
    public class AGhost : IWeapon
    {
        public void TheDeathWeapon()
        {
            Console.WriteLine("Rasputin is kinda dead and he has ghost magical power");
        }
    }
}
