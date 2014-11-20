using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationInClass4
{
    class Program
    {
        static void Main(string[] args)
        {
            Chair greenChair;
            int i;

            i = 7;
            greenChair = new Chair();
            greenChair.Height = 7;
            greenChair.NumLegs = 4;
            greenChair.HasBack = true;
            greenChair.HeightAjustable = false;

            Chair whiteChairStool = new Chair();
            whiteChairStool.HeightAjustable = false;
            whiteChairStool.NumLegs = 4;
            whiteChairStool.Height = 9;
            whiteChairStool.HasBack = true;

            Chair blackRollyChair = new Chair() { 
                HasBack = true, 
                Height = 5,
                NumLegs = 4,
                HeightAjustable = true };

            greenChair.RaiseHeight();
            greenChair.LowerHeight();

            //Make some dogs
            Dog myDog = new Dog();
            myDog.Name = "milo";
            myDog.Eat();
            myDog.Eat(7);

            Dog cheddar = new Dog("Cheddar");

            Dog roover = new Dog() { Name = "roover", BarkSound="Arf!" };
            Console.WriteLine(cheddar.Bark());
            Console.WriteLine(myDog.Bark());
            Console.WriteLine(roover.Bark());

            Console.WriteLine(roover.About());
            Console.WriteLine(myDog.About());
            Console.WriteLine(cheddar.About());


            Console.ReadKey();

        }
    }


}
