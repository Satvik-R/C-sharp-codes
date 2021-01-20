using Microsoft.VisualStudio.TestTools.UnitTesting;
using second;
using System;
using System.Collections.Generic;
using System.Text;

namespace second.Tests
{
    [TestClass()]
    public class PatientHelperTests
    {
        [TestMethod()]
        public void CheckIfVaccinationCompletedTest()
        {
            PatientHelper p = new PatientHelper();
            
            //string expected = "Your vaccinations are pending.Please contact your allocated doctor";
            //Assert.AreSame(Console.WriteLine(p.CheckIfVaccinationCompleted("Satvik")), expected);
        }
    }
}