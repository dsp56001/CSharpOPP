using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationWeek5
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Mammal> mams = new List<Mammal>();

            Dog d = new Dog();
            mams.Add(d);
            mams.Add(new Dog { Name = "Milo", BarkSound = "Arf!",
                Weight = 3 });
            mams.Add(new Dog
            {
                Name = "Fluffy",
                BarkSound = "Arrggggg!",
                Weight = 17
            });

            Cat punkin = new Cat();
            Platypus p = new Platypus();
            mams.Add(p);

            mams.Add(punkin);

            foreach (Mammal mam in mams)
            {
                Console.WriteLine(mam.About());
                //Tests the type
                if (mam is Dog)
                {
                    //Casts to the subtype
                    ((Dog)mam).Bark();
                }
                if (mam.GetType() == typeof(Cat))
                {
                    ((Cat)mam).Meow();
                }

            }

            Console.WriteLine(d.Bark());
            Basenji cheddar = new Basenji();
            Console.WriteLine(cheddar.About());
            Console.WriteLine(cheddar.Bark());

            Console.ReadKey();
        }
    }
}
