using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MHunArmy : IWicked
    {
        //concrete product
        public void Attack()
        {
            Console.WriteLine("Lead China Kill the King");
        }
    }
}
