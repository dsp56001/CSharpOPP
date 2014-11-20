using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationUsesA
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat punkin = new Cat();
            Toy spralklyball = new Toy() { Name = "sparkleyball" };
            punkin.GiveToy(spralklyball);
            Console.WriteLine(punkin.Play());

            Console.ReadKey();
        }
    }
}
