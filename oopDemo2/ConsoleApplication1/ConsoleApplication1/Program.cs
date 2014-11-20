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
            string CoolString = "cool";
            double money = 20.0;
            string notherCoolString = "coolio!!!";
            Console.WriteLine(String.Format("In \" \\ Line formating {0} of '{0}' {1} {2:c}", notherCoolString, CoolString, money));


            Console.WriteLine(CoolString.Replace("oo", "00"));
            Console.WriteLine(CoolString);

            SayHelloToConsole();
            SayHelloToConsole();
            SayHelloToConsole();

            string[] names = new string[3];
            names[0] = "jeff";
            names[1] = "sally";
            names[2] = "joe";

            string[] betterNames =  new string[] { "jeff", "mary" };

            Console.WriteLine(names[0]);
            Console.WriteLine(betterNames[0]);

            List<string> listName = new List<string>();
            listName.Add("jeff");
            listName.Add("mary");

            listName.Remove("jeff");

            bool isTrue = true;

            CheckIfTheBoolIsTrue(isTrue);

            isTrue = false;
            if (isTrue == true)
                Console.WriteLine("It's tru!!!!");

            Console.Write("How are you feeling today?");
            string Response = Console.ReadLine();

            Console.Write("What is you favorite number?");
            int FavortiteNumber = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }

        private static void CheckIfTheBoolIsTrue(bool isTrue)
        {
            if (isTrue == true)
                Console.WriteLine("It's tru!!!!");
        }

        static void SayHelloToConsole()
        {
            Console.WriteLine("from SayHelloToConsole: hello!");
        }

        static string SayHello()
        {
            return "SayHello says: Hello!";
        }

       
        static string SaySomething(string Something)
        {
            return string.Format("SaySomething says:{0}",
                Something);
        }

        protected static void WriteColorFullToConsole(string s)
        {
            //Save current console color so we can restore it when we are done
            //We don't want to leave the console with a random color
            ConsoleColor originalConsoleColor = Console.ForegroundColor;

            for (int index = 0; index < s.Length; index++)
            {

                Console.ForegroundColor = mycolors[(mycolors.Length + index) % mycolors.Length];   //Rotate through colors
                Console.Write(s[index]);    //Write the current letter from the string

            }
            Console.Write("\n");

            //Restore Console
            Console.ForegroundColor = originalConsoleColor;

        }

        //An array of console colors
        private static ConsoleColor[] mycolors =
        {
            ConsoleColor.Red,
            ConsoleColor.Magenta,
            ConsoleColor.DarkMagenta,
            ConsoleColor.DarkGreen,
            ConsoleColor.DarkRed,
            ConsoleColor.DarkGray,
            ConsoleColor.DarkBlue,
            ConsoleColor.Blue,
            ConsoleColor.Gray,
            ConsoleColor.Green,
            ConsoleColor.Yellow,
            ConsoleColor.White
        }; 





    }
}
