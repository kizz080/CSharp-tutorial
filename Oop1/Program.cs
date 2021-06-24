using System;

namespace Oop1
{
    class Person
    {
        private string _name;
        private string _surname;

        public Person(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public override string ToString()
        {
            return "The name of person is: " + _name + " The name of person is: " + _surname;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var people = new Person[3];

            for (int i = 0; i < 3; i++)
            {
                string name = Console.ReadLine();
                string surname = Console.ReadLine();
                var person = new Person(name, surname);
                people[i] = person;
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(people[i].ToString());
            }
        }
    }
}