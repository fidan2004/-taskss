using System;
using static ConsoleApp21.Program.Person;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    persons[i] = new Student(Console.ReadLine());
                }
            }
            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                   ((Teacher)persons[i]).Explain();

                }
                else
                {
                    ((Student)persons[i]).Study();
                }
            }
        }

        public class Person
        {
            public string name { get; set; }

            public Person(string name)
            {
                this.name = name;
            }
            public override string ToString()
            {
                return  name;

            }
            public class Teacher : Person
            {
                public Teacher(string name) : base(name)
                {
                    this.name = name;
                }
                public void Explain()
                {
                    Console.WriteLine("Explain");
                }


            }
            public class Student : Person
            {
                public Student(string name) : base(name)
                {
                    this.name = name;
                }
                public void Study()
                {
                    Console.WriteLine("Study");
                }
            }

        }
    }
}


