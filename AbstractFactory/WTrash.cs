using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WTrash : IWicked
    {
        //concrete product
        public void Attack()
        {
            Console.WriteLine("Cover Earth");
        }
    }
}