using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxTestProject.Contacts;

namespace TaxTestProject.Services
{
    public class TaxService
    {
        private readonly IRangeRepository _rangeRepository;

        public TaxService(IRangeRepository rangeRepository)
        {
            _rangeRepository = rangeRepository;
        }

        public decimal GetTax(decimal grossSalary)
        {
            var percentage = _rangeRepository.GetRange(grossSalary).Percentage;
            return grossSalary / 100 * percentage;
        }
    }
}
