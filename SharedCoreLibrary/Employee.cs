using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCoreLibrary
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(string firstname, string lastname)
        {
            Id = Guid.NewGuid();
            FirstName = firstname;
            LastName = lastname;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public Guid Id { get; set; }
    }
}
