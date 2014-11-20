using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funrature;

namespace ConsoleApplicationMostofMyDemosFromHereonOutUseDags
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog fido = new Dog { Age = 4, BarkSound = "Arf!", Name = "fido", Weight = 4 };
            fido.Eat();
            fido.Eat();
            fido.Eat();
            fido.Eat();
            fido.Eat();
            fido.Eat();
            Console.WriteLine(fido.About());

            Dog milo = new Dog();
            milo.Name = "Milo";
            milo.Age = 4;
            milo.BarkSound = "woof!";
            Console.WriteLine(milo.About());

            Dog d = new Dog();

            Chair c = new Chair() { HasBack = true, HeightAdjustable = true, Height = 44, NumLegs = 4 };
            Console.WriteLine(c.About());
            c.RaiseHeight();
            Console.WriteLine(c.About());
            c.LowerHeight();
            Console.WriteLine(c.About());
            for (int i = 0; i < 100; i++)
            {
                c.LowerHeight();
            }

            c.RaiseHeight(50);
            Console.WriteLine(c.About());

            Console.ReadKey();
        }

        private static void Bark(string DogName, int DogAge, string DogBarkSound)
        {
            Console.WriteLine(string.Format("Hello my name is {0} I'm {1} years old. My bark sounds like {2}",
                DogName, DogAge, DogBarkSound));
        }
    }

   


}
