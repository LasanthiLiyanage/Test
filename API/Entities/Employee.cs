using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string DateofBirth { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public Decimal BasicSalary { get; set; }
    }
}