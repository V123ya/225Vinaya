using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
   public class Department
    {
        public string GetDepartmentName()
        {
            return "IT Department";
        }
        public string GetNumberOfDepartments()
        {
            return "There are 4 Departments.";
        }
        public virtual string GetDepartmentDetails()
        {
            return "The Department Id is 5ND";
        }
    }
}
