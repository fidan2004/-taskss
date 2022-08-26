using System;
using static ConsoleApp22.Program.Animal;

namespace ConsoleApp22
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.SetName(Console.ReadLine());
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }
        public abstract class Animal
        {
          public string name;

            public void SetName(string name)
            {
                this.name = name;
            }

            public string GetName()
            {
                return name;
            }

            public abstract void Eat();
            public class Dog : Animal
            {
                public override void Eat()
                {
                    Console.WriteLine("Eating");
                }
            }
        }
    }
}

