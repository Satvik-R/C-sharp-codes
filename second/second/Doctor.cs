using System;
using System.Collections.Generic;
using System.Text;

namespace second
{
    public class Doctor: HospitalEntity
    {
        public DateTime EndTime { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime StartTime { get; set; }
    }
}
