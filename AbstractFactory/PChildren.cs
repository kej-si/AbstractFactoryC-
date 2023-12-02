using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PChildren : IHero
    {
        //concrete product
        public void Act()
        {
            Console.WriteLine("The Pirates are the ones to fight against");
        }
    }
}