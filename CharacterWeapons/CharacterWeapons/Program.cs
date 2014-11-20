using CharacterWeapoms.models.character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterWeapoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight brian = new Knight();

            Troll troll = new Troll() 
            { 
                Name = "Krug"
            };

            SpaceMarine chuck = new SpaceMarine() { Name = "chuck" };

            Console.WriteLine(brian.Attack(troll));
            Console.WriteLine(troll.Attack(troll));
            Console.WriteLine(troll.Attack(brian));
            Console.WriteLine(chuck.Attack(troll));
            Console.ReadKey();

        }
    }
}
