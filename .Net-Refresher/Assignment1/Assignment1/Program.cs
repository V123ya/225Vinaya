using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
                Employee emp = new Employee();
                string deptName    =  emp.GetDepartmentName();
                string NoOfDept    =  emp.GetNumberOfDepartments();
                string deptDetails =  emp.GetDepartmentDetails();
                string EFName      =  emp.GetEmployeeFirstName();
                string ELName      =  emp.GetEmployeeLastName();

                Console.WriteLine(NoOfDept + " The Employee " + EFName + ELName + " belongs to " + deptName + " and " + deptDetails);
            }
        }
    }