using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PSword : IWeapon
    {
        //concrete product
        public void TheDeathWeapon()
        {
            Console.WriteLine("Swords are the element to be used against the Pirates");
        }
    }
}