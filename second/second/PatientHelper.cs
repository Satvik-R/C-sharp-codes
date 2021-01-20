using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace second
{
    public class PatientHelper: Helper
    {

        
        public void CheckIfVaccinationCompleted( string patientName)
        {
            
            for (int i = 0; i < PatientList.Count; i++)
            {
                if (PatientList[i].Name == patientName)
                {
                    Patient p = PatientList[i];
                    if (p.IsFirstVaccinationCompleted && p.IsSecondVaccinationCompleted)
                    {
                        Console.WriteLine("You have completed your vaccination.Thank you!");
                        
                    }
                    else
                    {
                        Console.WriteLine("Your vaccinations are pending.Please contact your allocated doctor{0}",p.AllocatedDoctor);
                        
                    }
                }
                else
                {
                    Console.WriteLine("You are not yet registered for vacccination.Please register before proceeding");
                    
                }
            }
        }
        public List<Patient> GetPatientList()
        {
            return PatientList;
        }
        
        public void RegisterAppointmentForVaccination(string patientName)
        {
            
            for (int i = 0; i < PatientList.Count; i++)
            {
                if (PatientList[i].Name == patientName)
                {
                    Console.WriteLine("Dear {0}, you are already registered for vaccination with Dr.{1}", PatientList[i].Name,PatientList[i].AllocatedDoctor);
                    return;
                }
                else
                {
                    PatientList.Add(new Patient() { Id = 1, Name = patientName });
                    int c = PatientList.Count;

                    if (DoctorList.Count > 0)
                    {
                        PatientList[c-1].AllocatedDoctor = DoctorList[0];
                        //var PatientList = new List<Patient>(){ new Patient() { Id = 1, Name = patientName }};
                        DoctorList.RemoveAt(0);
                    }
                    else
                    {
                        
                        PatientList[c - 1].IsOnWaitingList = true;

                    }
                }
            }
        }
        public void AllocatingDoctor()
        {
            for (int i = 0; i < PatientList.Count - 1; i++)
            {
                if (PatientList[i].IsOnWaitingList)
                {
                    if (DoctorList.Count > 0)
                    {
                        Patient p = PatientList[i];
                        p.AllocatedDoctor = DoctorList[0];
                        p.IsOnWaitingList = false;
                        DoctorList.RemoveAt(0);
                    }
                    else
                    {
                        Console.WriteLine("There are no available doctors");
                        return;
                    }
                }
                
            }
        }
    }
}
