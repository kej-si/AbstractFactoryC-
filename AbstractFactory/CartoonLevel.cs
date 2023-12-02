using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CartoonLevel
    {
        private IDisneyFactory _cartoonFactory;

        public CartoonLevel(IDisneyFactory cartoonFactory)
        {
            _cartoonFactory = cartoonFactory;
        }

        public void CreateLevel()
        {
            var hero = _cartoonFactory.CreateHero();
            var wicked = _cartoonFactory.CreateWicked();
            var weapon = _cartoonFactory.CreateWeapon();
            var place = _cartoonFactory.CreatePlace();


            Console.WriteLine("Starting the game...");


            Console.WriteLine("Placing heroin the game world...");
            hero.Act();

            Console.WriteLine("Placing enemy in the game world...");
            wicked.Attack();


            Console.WriteLine("Placing weapon in the game world...");
            weapon.TheDeathWeapon();

            Console.WriteLine("Displaying the game environment...");
            place.Display();
        }
    }
}
