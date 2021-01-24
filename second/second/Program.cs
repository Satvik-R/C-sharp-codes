using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace second
{
 
    public class Program
    {
        
        static void Main(string[] args)
        {
            
            Doctor d = new Doctor("Karam",3);
            AssistantDoctor ad = new AssistantDoctor("Karambrother", 3);
            Patient p = new Patient();
            //Helper he = new Helper();
            DoctorHelper dh = new DoctorHelper();
            PatientHelper ph = new PatientHelper();
            Console.WriteLine(dh.DoctorList[0].Name);
            ph.RegisterAppointmentForVaccination("satvik");
            ph.RegisterAppointmentForVaccination("Prasoon");
            ph.RegisterAppointmentForVaccination("Krishna");
            ph.RegisterAppointmentForVaccination("satvik");
            ph.RegisterAppointmentForVaccination("Kumar");

            dh.DoctorList.Add(new Doctor("Kiran", 4) { AsstDoctor = new AssistantDoctor("Kiransister", 4) });
            ph.AllocatingDoctor();


            foreach (Patient patient in ph.PatientList)
            {
                ph.CheckIfVaccinationCompleted(patient.Name);
            }
            foreach (Doctor doctor in dh.DoctorList)
            {
                Console.WriteLine("Doctor {0} has assistant doctor {1}",doctor.Name,doctor.AsstDoctor.Name);
            }

            Action<string> del = e => ph.RegisterAppointmentForVaccination(e);
            del("Kumar");
            //try
            //{



            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

        }

    }
}
























