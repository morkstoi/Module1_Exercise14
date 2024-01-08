using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Gabriel");
            cat.ShowInfo();
            Console.WriteLine("");
            Dog dog = new Dog("Rex");
            dog.ShowInfo();
            Console.ReadKey();

        }
    }

    abstract class Animal
    {

        abstract public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name); ;
            Say();
        }
    }

    class Cat : Animal
    {
        private string name;
        public override string Name
        {
            get => name;
            set => value = name;
        }

        public Cat(string name)
            : base(name)
        {
            this.name = name;
        }
        public override void Say()
        {
            Console.WriteLine("Мяу!"); ;
        }
    }
    class Dog : Animal
    {
        private string name;
        public override string Name
        {
            get => name;
            set => value = name;
        }

        public Dog(string name)
            : base(name)
        {
            this.name = name;
        }
        public override void Say()
        {
            Console.WriteLine("Гав!"); ;
        }
    }

}
