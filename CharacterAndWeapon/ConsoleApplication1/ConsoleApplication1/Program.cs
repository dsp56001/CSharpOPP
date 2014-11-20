using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Viking Ragnar = new Viking();
            SpaceMarine Smith = new SpaceMarine();
            Warrior w = new Warrior();

            Console.WriteLine(Smith.Attack(Ragnar));
            Smith.Weapon = new ShotGun();
            Console.WriteLine(Smith.Attack(Ragnar));

            Console.WriteLine(Ragnar.Attack(w));
            Console.ReadKey();

        }
    }
}
