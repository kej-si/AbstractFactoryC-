using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the wicked specific to Mulan
    public class MHunArmy : IWicked
    {
        public void Attack()
        {
            Console.WriteLine("Lead China Kill the King");
        }
    }
}
