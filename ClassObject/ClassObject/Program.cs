using System;
using System.Text.RegularExpressions;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            //string text = "Kamran Gunel fsdgsf Kamran Ulvi Gunel Ibrahim";
            //string result=Regex.Replace(text, "Kamran", "Ela");
            //bool hasDigit = Regex.IsMatch(text, @"\d");
            //Console.WriteLine(hasDigit);
            #endregion

            #region Object,Class
            //anonimous object
            //var obj1 = new
            //{
            //    name="Esker",
            //    surname="Xudadatov",
            //    age=21,
            //    birthday="fsdgsg"
            //};

            //var obj2 = new
            //{
            //    name = "Altun",
            //    surname = "Asifli",
            //    age = 21,
            //    birthday = "fsdgsg"
            //};

            //Console.WriteLine($"{obj1.name} {obj1.surname} {obj1.age}");
            //Console.WriteLine($"{obj2.name} {obj2.surname} {obj2.age}");
            //instance
            Student obj1 = new Student("Esker", "Xudadatov",21);
            //obj1.name = "Esker";
            //obj1.surname = "Xudadatov";
            //obj1.age = 21;

            Student obj2 = new Student("Altun", "Asifli",21);
            Student obj = new Student();
            //Console.WriteLine(obj.Detail());
            //obj2.name = "Altun";
            //obj2.surname = "Asifli";
            //obj2.age = 22;
            //Console.WriteLine(obj1.Fullname());
            //Console.WriteLine(obj2.Fullname());
            //Console.WriteLine(obj1.Detail());
            //Console.WriteLine(obj2.Detail());
            #endregion

        }
    }
}
