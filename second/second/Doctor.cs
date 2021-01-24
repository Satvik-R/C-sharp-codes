using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace second
{
    public class Doctor: Staff
    {
        public DateTime EndTime { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime StartTime { get; set; }
        public AssistantDoctor AsstDoctor { get; set; }

        

        public Doctor(String name,int id):base(name,id)
        {

        }

        public override double BasicSalary()
        {
            double Incentive = 0.3 * base.BasicSalary();
            return Incentive + base.BasicSalary();
        }

        public override double CalculateSalary()
        {
            double totalSalary = BasicSalary() + 0.2 * BasicSalary();
            return totalSalary;
            
        }
    }
}
