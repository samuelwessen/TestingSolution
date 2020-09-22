using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SharedCoreLibrary.Tests
{
    public class EmployeeTests
    {
        private List<Employee> _employees { get; set; }

        public EmployeeTests()
        {
            _employees = new List<Employee>();
        }

        [Theory]
        [InlineData("Hans","Mattin-Lassei")]
        [InlineData("Tommy", "Mattin-Lassei")]
        public void AddEmployee_ShouldAddAnEmployeeToAListOfEmployees(string firstname, string lastname)
        {
            var employee = new Employee(firstname, lastname);
            _employees.Add(employee);

            Assert.Contains(employee, _employees);
        }

        [Fact]
        public void FullName_ShouldReturnTheFullNameOfTheEmployee()
        {
            Employee employee = new Employee() { FirstName = "Hans", LastName = "Mattin-Lassei" };
            Assert.Equal("Hans Mattin-Lassei", employee.FullName);
        }


        [Fact]
        public void Id_ShouldReturnGuidId()
        {
            Guid _id = Guid.NewGuid();

            Employee employee = new Employee() { Id = _id };
            Assert.Equal(_id, employee.Id);
        }
    }
}
