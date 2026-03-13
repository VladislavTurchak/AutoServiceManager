using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceManager.Models
{
    // Клас MaintenanceService описує технічне обслуговування (ТО)
    // Наслідує базовий абстрактний клас Service
    public class MaintenanceService : Service
    {
        // Перевизначення методу розрахунку ціни
        // Для ТО ціна просто базова (фіксована)
        public override decimal CalculatePrice()
        {
            return BasePrice;
        }
    }
}
