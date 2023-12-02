using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MKarate : IWeapon
    {
        //concrete product
        public void TheDeathWeapon()
        {
            Console.WriteLine("Mulan is the top Karate fighter utulize the skill to max");
        }
    }
}
