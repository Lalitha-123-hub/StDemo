using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StDemo
{
    internal class Employee
    {
        int EmployeeId;
        string EmployeeName;
        String DepartmentName;
        string Designation;
        double Salary;

        public Employee()
        {

        }
        public Employee(int EmpId, string EmpName )
        {
            EmployeeId = EmpId; 
            EmployeeName = EmpName;
        }
        public Employee(int EmpId, string EmpName, string DName)
        {
            EmployeeId = EmpId;
            EmployeeName = EmpName;
            Designation = DName;
            
        }
        public Employee(int EmpId, string EmpName, string DName, string designation) 
        {
            EmployeeId=EmpId;
            EmployeeName = EmpName;
            Designation = DName;
            Designation = designation;
        }
        public Employee(int EmpId, string EmpName, string DName, string designation,double Sal)
        {
            EmployeeId = EmpId;
            EmployeeName = EmpName;
            Designation = DName;
            Designation = designation;
            Salary = Sal;
        }

        public void showEmployee()
        {
            Console.WriteLine(EmployeeId+ " "+ EmployeeName + " " + DepartmentName + " "+ Designation+ " " +
                Salary);
        }
        ~Employee()
        { 
                Console.WriteLine ("destructor");
        }
    }
}
