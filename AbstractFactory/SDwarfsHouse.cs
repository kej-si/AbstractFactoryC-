using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the place specific to Snowwhite
    public class SDwarfsHouse : IPlace
    {
        public void Display()
        {
            Console.WriteLine("The wich went to the Dwarfs House. Snowwhite fell sick.");
        }
    }
}
