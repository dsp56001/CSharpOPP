using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyAgain
{
    class ShoppingCart
    {

        List<Product> Items;

        public ShoppingCart()
        {
            this.Items = new List<Product>();
        }
        
        internal string Total()
        {
            double total = 0;
            string cartList = "";
            foreach (Product p in Items)
            {
                cartList += string.Format("\n{0}\t{1:c}", p.Name, p.Cost);
                total += p.Cost;
            }

            return string.Format("{0}\ntotal:{1:c}",cartList, total);
        }

      
        internal void Add(Product p)
        {
            this.Items.Add(p);
        }
    }
}
