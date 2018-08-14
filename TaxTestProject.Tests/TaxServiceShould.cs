using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxTestProject.Services;

namespace TaxTestProject.Tests
{
    [TestClass]
    public class TaxServiceShould
    {
        [TestMethod]
        public void Returns1000IfGrossSalaryIs9500()
        {
            var taxService = new TaxService();
            Assert.AreEqual(1000, taxService.GetTax(9500));
        }
    }
}
