using System;
using System.Collections.Generic;

namespace ClassesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class1> students = new List<Class1>;
          
            Class1 stud1 = new Class1();
            Class1.name = "Micah";
            Class1.id = 2;
            students.Add(stud1);

            Class1 stud2 = new Class1("Adam", 1);
            students.Add(stud2);

            foreach (var stud in students)
            {

                Console.WriteLine($"{stud.name} has an id of {stud.id}");
            }



            //Console.WriteLine($"{stud1.name} has an id of { stud1.id}");
            //Console.WriteLine($"{stud2.name} has an id of { stud2.id}");

        }
    }
}
