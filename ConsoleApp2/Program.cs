using System;

namespace SP
{
    class Person
    {
        private string _A;
        private string _B;

        public Person(string S, string P)
        {
            _S = S;
            _P = P;
        }

        public override string ToString()
        {
            return "The name of person is: " + _S + " The name of person is: " + _P;
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