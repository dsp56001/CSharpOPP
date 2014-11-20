using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make products
            Nachos n = new Nachos();
            Bike b = new Bike();

            //Add products to shopping cart
            ShoppingCart cart = new ShoppingCart();
            cart.Add(n);
            cart.Add(b);

            //write total from cart 
            Console.WriteLine(cart.Total());

            //Add game to my cart
            cart.Add(new Game());
            Console.WriteLine(cart.Total());
            Console.ReadKey();
        }
    }
}
