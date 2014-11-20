using Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationDogAccesors
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Console.WriteLine(d.Name);
            d.Name = "roover";

            d.Eat();
            d.Eat();
            d.Eat();
            Console.WriteLine(d.Weight);
            d.Poop();
            Console.WriteLine(d.Weight);
            Console.ReadKey();
        }
    }
}
