using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SDwarfsHouse : IPlace
    {
        //concrete product
        public void Display()
        {
            Console.WriteLine("The wich went to the Dwarfs House. Snowwhite fell sick.");
        }
    }
}
