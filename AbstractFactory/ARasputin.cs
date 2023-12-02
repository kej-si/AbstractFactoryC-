using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ARasputin : IWicked
    {
        //concrete product
        public void Attack()
        {
            Console.WriteLine("Anastasia is the last Romanov. She must be killed");
        }
    }
}
