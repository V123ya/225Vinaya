using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
   public class Employee : Department
    {
        public string GetEmployeeFirstName()
        {
            return "Radha";
        }
        public string GetEmployeeLastName()
        {
            return "Krishna";
        }
        public override string GetDepartmentDetails()
            {
            return " the Department Id is 4SD";
        }
    }
}
