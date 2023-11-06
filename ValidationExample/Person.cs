using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ValidationExample
{
    internal class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
                Name = name;
                Age = age;
        }

        public Person(string name, string age)
        {
            Name = name;
            Age = Convert.ToInt32(age);
        }

        public override string ToString()
        {
            return $"{Name} ({Age})";
        }
    }
}
