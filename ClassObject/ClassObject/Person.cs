using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObject
{
    class Person
    {
        public string name;
        public string surname;
        public int age;
        public DateTime birthday;
        public Person parent;
        public Person()
        {

        }
        public Person(string s)
        {
            Console.WriteLine("Person constructor");
        }
        public string Fullname()
        {
            return $"{name} {surname}";
        }

        public string Detail()
        {
            return $"{Fullname()} {age}";
        }
    }
}
