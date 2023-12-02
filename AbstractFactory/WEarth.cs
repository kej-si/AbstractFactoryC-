using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the place specific to WallE
    public class WEarth : IPlace
    {
        public void Display()
        {
            Console.WriteLine("Earth has become full with trash and inhabitabile");
        }
    }
}
