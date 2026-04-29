using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceManager.Models
{
    // Вимога курсової:
    // Наслідування від Service
    public class RepairService : Service
    {
        public int Hours { get; set; }

        // Вимога курсової:
        // Поліморфізм (перевизначення методу)
        public override decimal CalculatePrice()
        {
            return BasePrice * Hours;
        }
    }
}