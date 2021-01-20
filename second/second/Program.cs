using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
 
    public class Program
    {
        static void Main(string[] args)
        {
            HospitalEntity h = new HospitalEntity();
            Doctor d = new Doctor();
            Patient p = new Patient();
            Helper he = new Helper();
            DoctorHelper dh = new DoctorHelper();
            PatientHelper ph = new PatientHelper();
            Console.WriteLine(he.DoctorList[0].Name);
            ph.RegisterAppointmentForVaccination("satvik");
            Console.WriteLine(he.PatientList);
            try
            {
                Console.WriteLine(he.PatientList[1].Name);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }

    }
}
























