using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxTestProject.Entities;

namespace TaxTestProject.Contacts
{
    public interface IRangeRepository
    {
        Range GetRange(decimal grossSalary);
    }
}
