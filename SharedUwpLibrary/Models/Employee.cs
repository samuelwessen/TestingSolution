using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedUwpLibrary.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public string FullName => $"{FirstName} {LastName}";


        public Employee()
        {
            // var employee = new Employee();
            // employee.FirstName = "Hans";

            // var employee = new Employee() { FirstName = "Hans", LastName = "Mattin-Lassei", Department = "Dev" }
        }


        public Employee(string firstname, string lastname)
        {
            Id = Guid.NewGuid();
            FirstName = firstname;
            LastName = lastname;

            // var employee = new Employee("Hans", "Mattin-Lassei"); 
        }


        public Employee(string firstname, string lastname, string department)
        {
            Id = Guid.NewGuid();
            FirstName = firstname;
            LastName = lastname;
            Department = department;

            // var employee = new Employee("Hans", "Mattin-Lassei", "Dev"); 
        }

    }
}
