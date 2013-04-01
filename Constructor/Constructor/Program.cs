using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        class Name
        {
            private string firstName
            { get; set; }

            private string lastName
            { get; set; }

            private int age
            { get; set; }

            public Name(string firstName, string lastName, int age)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
            }

            public void Display()
            {
                Console.WriteLine("{0} {1} is {2} years old", firstName, lastName, age);
            }
        }
            

        static void Main(string[] args)
        {
            Name myname = new Name("Payam", "Shoghi", 31);
            myname.Display();
            Console.ReadLine();

        }
    }
}
