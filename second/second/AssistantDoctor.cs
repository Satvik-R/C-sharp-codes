using System;
using System.Collections.Generic;
using System.Text;

namespace second
{
    public class  AssistantDoctor : Staff
    {
        public AssistantDoctor(string name, int id) : base(name, id) { }

        public new double BasicSalary()
        {
            return 15000;
        }

        public override double CalculateSalary()
        {
            double totalSalary = 0.15 * BasicSalary() + BasicSalary();
            return totalSalary;
        }

    }
}
