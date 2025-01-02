using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskoop1
{
    internal struct person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
