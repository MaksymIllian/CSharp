using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lecture4
{
    [Serializable]

    public class Employee
    {
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        private string employeeID;
        public Employee()
        { }

        public Employee(string FirstName, string LastName, int Age, string Department, string Address)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Department = Department;
            this.Address = Address;
        }
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
    }
}
