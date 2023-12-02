using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SDwarfs : IHero
    {
        //concrete product
        public void Act()
        {
            Console.WriteLine("Notify the Prince!!");
        }
    }
}
