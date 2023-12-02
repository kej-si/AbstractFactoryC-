using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Concrete product class representing the villian specific to Anastasia
    public class ARasputin : IWicked
    {
        public void Attack()
        {
            Console.WriteLine("Anastasia is the last Romanov. She must be killed");
        }
    }
}
