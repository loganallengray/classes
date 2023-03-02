using System;

namespace Classes
{
    public class Employee
    {

        // Some readonly properties (let's talk about gets, baby)
        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
        public DateTime StartDate { get; }

        // Constructor
        public Employee(string _FirstName, string _LastName, string _Title)
        {
            FirstName = _FirstName;
            LastName = _LastName;
            Title = _Title;
            StartDate = DateTime.Now;
        }
    }
}