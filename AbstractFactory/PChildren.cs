using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the hero specific to Peter Pan
    public class PChildren : IHero
    {
        public void Act()
        {
            Console.WriteLine("The Pirates are the ones to fight against");
        }
    }
}