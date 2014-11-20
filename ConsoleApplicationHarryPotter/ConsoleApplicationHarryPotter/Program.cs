using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationHarryPotter
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Make a coin
            int intCoin1;
            int numHeads = 0;

            int coinsToFlip = 0;
            Console.WriteLine("how many coins would yo ulike to flip");
            int.TryParse(Console.ReadLine(), out coinsToFlip);
            Random r = new Random();
            for(int i = 0; i<coinsToFlip; i++)
            {
                //Flip it
                
                intCoin1 = r.Next(2);          //Two is the max so we will get 0 and 1
                if (intCoin1 == 0)
                {
                    numHeads++;
                }
                //Write the results
                Console.WriteLine((CoinSides)intCoin1);
            }
            Console.WriteLine(String.Format("{0} {1:N0}%", numHeads, ((float)numHeads / (float)coinsToFlip) * 100));
            
            Console.ReadKey();
        }

        enum CoinSides { heads, tails };
    }
}
