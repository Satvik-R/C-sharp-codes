using System;
using System.Collections.Generic;
using System.Text;

namespace second
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Doctor AllocatedDoctor { get; set; }
        public DateTime FirstVaccinationDate { get; set; }
        public bool IsFirstVaccinationCompleted { get; set; }
        public bool IsOnWaitingList { get; set; }
        public bool IsSecondVaccinationCompleted { get; set; }

        public DateTime SecondVaccinationDate { get; set; }

        
    }
}
