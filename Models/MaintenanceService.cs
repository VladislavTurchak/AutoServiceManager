using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceManager.Models
{
    // Вимога курсової:
    // Наслідування від абстрактного класу Service
    public class MaintenanceService : Service
    {
        // Вимога курсової:
        // Поліморфізм (перевизначення методу)
        public override decimal CalculatePrice()
        {
            return BasePrice;
        }
    }
}