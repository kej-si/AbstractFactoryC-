using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PCapHook : IWicked
    {
        //concrete product
        public void Attack()
        {
            Console.WriteLine("Kick out of Neverland Peter and the kids");
        }
    }
}