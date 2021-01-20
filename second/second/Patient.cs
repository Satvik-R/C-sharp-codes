using System;
using System.Collections.Generic;
using System.Text;

namespace second
{
    public class Patient: HospitalEntity
    {
        public Doctor AllocatedDoctor { get; set; }
        public DateTime FirstVaccinationDate { get; set; }
        public bool IsFirstVaccinationCompleted { get; set; }
        public bool IsOnWaitingList { get; set; }
        public bool IsSecondVaccinationCompleted { get; set; }

        public DateTime SecondVaccinationDate { get; set; }
    }
}
