using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MMulan : IHero
    {
        //concrete product
        public void Act()
        {
            Console.WriteLine("Fight Hun Army to protect China and the King");
        }
    }
}