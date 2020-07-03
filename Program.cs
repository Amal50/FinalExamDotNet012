using System;

namespace FinalExamDotNet012
{
    class Program
    {
        static void Main(string[] args)
        {
            Adult[] array = new Adult[2];
            array[0] = new Adult("AdultFName", "AdultLastName");
            array[1] = new Child("ChildAmal", "ChildAljohari");

            for(var i = 0; i< array.Length; i++)
            {
                Console.WriteLine($"First name: {array[i].FirstName} , Last Name: {array[i].LastName}");
            }
        }
    }

    public class Adult
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Adult(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
    public class Child : Adult
    {

        public Child(string firstName, string lastName) :base(firstName, lastName)
        {

        }

    }
}
