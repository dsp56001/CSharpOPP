using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationStaticDob
{
    public class Person
    {
        public string Name;      //the color of the hydrant

        public Person()
        {
            Name = "Karen";
        }

        public Person(string newName)
        {
            Name = newName;
        }

        public Dog Dog
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
