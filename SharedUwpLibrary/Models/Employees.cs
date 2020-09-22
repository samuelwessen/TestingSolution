using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedUwpLibrary.Models
{
    public class Employees : ObservableCollection<Employee>
    {
        public Employees()
        {
            Add(new Employee("Hans", "Mattin-Lassei", "Administration"));
            Add(new Employee("Tommy", "Mattin-Lassei", "Administration"));
        }
    }
}
