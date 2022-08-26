using System;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Person[]persons = new Person[a];    
            for(int i = 0; i < a; i++)
            {
                persons[i] = new Person(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }

        }
        class Person
        {
            public string name;

            public Person(string name)
            {
                this.name = name;
            }
            public override string ToString()
            {
                return "hello, my name is "  + name  ;
            }
            ~Person()
            {
              name = string.Empty;
            }
        }
    }
}
