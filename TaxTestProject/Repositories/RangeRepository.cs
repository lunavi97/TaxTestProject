using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxTestProject.Contacts;
using TaxTestProject.Entities;

namespace TaxTestProject.Repositories
{
    public class RangeRepository : IRangeRepository
    {
        private readonly List<Range> _ranges;

        public RangeRepository()
        {
            string jsonFile = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "ranges.json");
            _ranges = JsonConvert.DeserializeObject<List<Range>>(
                File.ReadAllText(jsonFile, Encoding.UTF8));
        }

        public Range GetRange(decimal grossSalary)
        {
            throw new NotImplementedException();
        }
    }
}
