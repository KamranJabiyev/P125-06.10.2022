using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObject
{
    //inheretance/extend
    class Student:Person
    {
        //constructor -is a method,call only instance,same name with class,nt return type!!!
        public Student()
        {
            Console.WriteLine("Student created");
        }

        public Student(string name, string s):base(name)
        {
            this.name = name;
            surname = s;
        }
        public Student(string name,string s,int a):this(name,s)
        {
            age = a;
        }
    }
}
