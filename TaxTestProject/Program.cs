using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxTestProject.Repositories;
using TaxTestProject.Services;

namespace TaxTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salario bruto anual:");
            var grossStr = Console.ReadLine();
            if (!Decimal.TryParse(grossStr, out decimal gross))
            {
                Console.WriteLine("No es un valor válido. Pulsá enter para salir.");
                Console.ReadLine();
                return;
            }

            var taxService = new TaxService(new RangeRepository());
            Console.WriteLine($"Vas a pagar {taxService.GetTax(gross)}.");
            Console.ReadKey();
        }
    }
}
