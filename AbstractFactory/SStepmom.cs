using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SStepmom : IWicked
    {
        //concrete product
        public void Attack()
        {
            Console.WriteLine("Get Snowwhite to eat the poisoned APPLE");
        }
    }
}
