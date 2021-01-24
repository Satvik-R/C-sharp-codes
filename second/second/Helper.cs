using System;
using System.Collections.Generic;
using System.Text;

namespace second
{
    
    public class Helper
    {
        public List<Doctor> DoctorList = new List<Doctor>()
        { new Doctor("Anand",1),
          new Doctor(id : 2,name : "Vikram"),
          new Doctor("Sanjeev", 3)
        };
        public List<Patient> PatientList = new List<Patient>();
        public List<AssistantDoctor> AssistantDoctorList = new List<AssistantDoctor>()
        { new AssistantDoctor("Anandbrother", 1),
            new AssistantDoctor("Vikrambrother",2),
            new AssistantDoctor("Sanjeevbrother",3)
        };

        


        public Helper()
        {
            
            for (int i= 0; i < DoctorList.Count;i++)
            {
                DoctorList[i].AsstDoctor = AssistantDoctorList[i]; 
            }

        }

        public void DeAllocatingDoctor()
        {
            foreach (Patient p in PatientList)
            {
                if (p.SecondVaccinationDate < DateTime.Now)
                {
                    DoctorList.Add(p.AllocatedDoctor);
                }
            }
        }



    }
}
