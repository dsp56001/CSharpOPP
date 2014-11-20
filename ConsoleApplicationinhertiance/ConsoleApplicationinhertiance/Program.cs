using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationinhertiance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mammal> animalChoir = new List<Mammal>();

            Dog d = new Dog();
            
            animalChoir.Add(d);
            animalChoir.Add(new Dog() { Name = "milo", BarkSound = "arf!" });

            Cat c = new Cat();
            Console.WriteLine(c.About());
            animalChoir.Add(c);

            Basenji cheddar = new Basenji();
            cheddar.Name = "Cheddar";
            
            animalChoir.Add(cheddar);

            foreach (var choirMemeber in animalChoir)
            {
                Console.WriteLine(choirMemeber.About());
            }

            foreach (var choirMemeber in animalChoir)
            {
               Console.WriteLine(choirMemeber.Sing());
            }

            

            Console.ReadKey();
        }
    }
}
