using System;

namespace Oop1
{
    class SP
    {
        private string _name;
        
        // public string FirstName;
        // public string LastName;

        // public Person()
        // {
        //     Console.WriteLine("Default constructor called");
        // }
        
        public (string name)
        {
            // Console.WriteLine("Parametrised constructor called");
            _name = name;
        }
        
        public override string ToString()
        {
            return "The name of person is: " + _name;
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
                
                // var person =  new Person();
                // person.Name = name;
                
                var person =  new Person(name);
                
                people[i] = person;
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(people[i].ToString());
            } 
        }
    }
}