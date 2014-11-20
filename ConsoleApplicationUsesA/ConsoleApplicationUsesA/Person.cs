using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationUsesA
{
    class Person
    {
        public string Name;

        public Person()
        {
            this.Name = "unnamed owner";
        }
        public Person(string name)
        {
            this.Name = name;
        }
    }
}
