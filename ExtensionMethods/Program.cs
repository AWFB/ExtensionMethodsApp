using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "What is your first name: ".RequestString();
            person.LastName = "What is your last name: ".RequestString();

            // Either way works
            person.Age = "What is your age: ".RequestInt(0, 130);
            person.Age = ConsoleExtensions.RequestInt("What is your age: ", 0, 130);

            // Print result
            Console.WriteLine($"Hello {person.FirstName} {person.LastName}, you are {person.Age} years old");
            Console.ReadLine();
        }
    }
}
