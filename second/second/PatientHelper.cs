using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace second
{
    public class PatientHelper: Helper
    {
        public PatientHelper()
        {
            if (DoctorList.Count > 0)
                AllocatingDoctor();
        }

        
        public void CheckIfVaccinationCompleted( string patientName)
        {
            
            var p = PatientList.Where(e => (e.Name == patientName)).FirstOrDefault();

            //for (int i = 0; i < PatientList.Count; i++)
            //{
            //    if (PatientList[i].Name == patientName)
            //    {
            if (p!=null)
            { 
                
                    
                if (p.IsFirstVaccinationCompleted && p.IsSecondVaccinationCompleted)
                {
                    Console.WriteLine("You have completed your vaccination.Thank you!");
                        
                }
                else
                {
                    if (p.AllocatedDoctor == null)
                    {
                        Console.WriteLine("{0}: Your vaccinations are pending.Please contact your allocated doctor and you will be allocated a doctor shortly", p.Name);

                    }
                    else
                    {
                        Console.WriteLine("{0}: Your vaccinations are pending.Please contact your allocated doctor {1}", p.Name, p.AllocatedDoctor.Name);
                    }
                }
            }
            else
            {
                Console.WriteLine("You are not yet registered for vacccination.Please register before proceeding");
                    
            }
            
        }
        public List<Patient> GetPatientList()
        {
            return PatientList;
        }
        
        public void RegisterAppointmentForVaccination(string patientName)
        {
            var p = PatientList.Where(e => e.Name.Equals(patientName)).Select(e=>new { e.Name, e.AllocatedDoctor }).FirstOrDefault();
           // Console.WriteLine(p.Equals);

            //for (int i = 0; i < PatientList.Count; i++)
            //{
            //    if (PatientList[i].Name == patientName)
            if(p!=null)
            {
                Console.WriteLine("Dear {0}, you are already registered for vaccination with Dr.{1}",p.Name, p.AllocatedDoctor.Name);
                
            }
            
            else
            {
                PatientList.Add(new Patient() { Id = 1, Name = patientName });
                int c = PatientList.Count;

                if (DoctorList.Count > 0)
                {
                    PatientList[c - 1].AllocatedDoctor = DoctorList[0];
                    //var PatientList = new List<Patient>(){ new Patient() { Id = 1, Name = patientName }};
                    DoctorList.RemoveAt(0);
                }
                else
                {

                    PatientList[c - 1].IsOnWaitingList = true;

                }

            }
        }
        public void AllocatingDoctor()
        {
            
            DeAllocatingDoctor();
            //for (int i = 0; i < PatientList.Count - 1; i++)
            //{
            //    if (PatientList[i].IsOnWaitingList)
            //    {
            var WaitingListPatient = PatientList.Where(p => p.IsOnWaitingList == true);
            foreach(Patient patient in WaitingListPatient)
            { 
                if (DoctorList.Count > 0)
                {
                    //Patient p = PatientList[i];
                    patient.AllocatedDoctor = DoctorList[0];
                    patient.IsOnWaitingList = false;
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

