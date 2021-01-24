using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> unitList = new List<Unit>()
            {
                new Unit{ UnitId = 10, UnitName = "ETA"},
                new Unit{ UnitId = 20, UnitName = "FSI"},
                new Unit{ UnitId = 30, UnitName = "ECS"}
            };
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee {EmployeeName = "John",UnitId=10,ProjectCode="ETAMYS",Salary=30000,JobLevel=3,JoiningDate=new DateTime(2014,3,5)},
                new Employee {EmployeeName = "Jack",UnitId=10,ProjectCode="ETACHN",Salary=35000,JobLevel=3,JoiningDate=new DateTime(2011,3,5)},
                new Employee {EmployeeName = "Albus",UnitId=10,ProjectCode="ETACHN",Salary=15000,JobLevel=4,JoiningDate=new DateTime(2011,3,5)},
                new Employee {EmployeeName = "Ron",UnitId=20,ProjectCode="FSIAUS",Salary=10000,JobLevel=4,JoiningDate=new DateTime(2007,2,5)},
                new Employee {EmployeeName = "Iwa",UnitId=20,ProjectCode="FSIAUS",Salary=15000,JobLevel=4,JoiningDate=new DateTime(2007,2,5)},
                new Employee {EmployeeName = "Albert",UnitId=30,ProjectCode=null,Salary=20000,JobLevel=3,JoiningDate=new DateTime(2005,1,5)}
            };

        }

    }
}
