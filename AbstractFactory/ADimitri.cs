using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ADimitri : IHero
    {
        //concrete product
        public void Act()
        {
            Console.WriteLine("Atack Rasputin and his creatures");
        }
    }
}
