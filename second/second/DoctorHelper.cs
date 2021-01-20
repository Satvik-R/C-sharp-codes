using System;
using System.Collections.Generic;
using System.Text;

namespace second
{
    public class DoctorHelper: Helper
    {
        public DoctorHelper()
        {   }
        public List<Doctor> GetAvailableDoctors()
        {
            
            foreach (var doc in DoctorList)
            {
                if (doc.IsAvailable)
                {
                    Console.WriteLine(doc.Name);
                    

                }
                else
                {
                    DoctorList.Remove(doc);
                    
                }
                    
            }
            return DoctorList;
        }


    }
}
