using System;
using System.Collections.Generic;
using System.Text;

namespace second
{
    public abstract class Staff
    {
        public static int counter;
        public int id;
        public int Id { get; set; }
        public string Name { get; set; }

        static Staff()
        {
            counter = 2;
        }

        //public Staff()
        //{ id = ++counter; }

        public Staff(string name,int id)
        {
            this.Name = name;
            this.Id = id;
        }
        public virtual double BasicSalary()
        {
            return 20000;
        }

        public abstract double CalculateSalary();
        




         
    }
}