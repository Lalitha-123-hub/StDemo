using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1=new Employee(9001, "John");
            e1.showEmployee();
            Employee e2 = new Employee(9002, "Miller", "Solutions");
            e2.showEmployee();
            Employee e3 = new Employee(9003, "swamy Nadhan ", "Solution", "Developer");
            e3.showEmployee();
            Employee e4 = new Employee(9004, "Kiran", "Testing", "QA", 20000.00);
            e4.showEmployee();
        }
    }
}
