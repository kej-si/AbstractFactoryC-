using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SPoisonedApple : IWeapon
    {
        //concrete product
        public void TheDeathWeapon()
        {
            Console.WriteLine("The witch Poisoned a big shinny juiciy Apple");
        }
    }
}
