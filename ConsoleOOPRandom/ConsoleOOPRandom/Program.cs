using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOP3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Make a coin
            int intCoin1;
 
            //Flip it
            Random r = new Random();
            while(true)
            {
            intCoin1 = r.Next(2);          //Two is the max so we will get 0 and 1
 
            //Write the results
            Console.WriteLine( (CoinSides)intCoin1);
            Console.ReadKey();
            }
        }
    
 
    enum CoinSides { heads =0, tails =1 };
    
    }
}
