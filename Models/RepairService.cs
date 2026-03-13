using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceManager.Models
{
    // Клас RepairService описує ремонт автомобіля
    // Наслідує базовий клас Service
    public class RepairService : Service
    {
        // Кількість годин ремонту
        public int Hours { get; set; }

        // Перевизначення методу розрахунку ціни
        // Вартість = базова ціна * кількість годин
        public override decimal CalculatePrice()
        {
            return BasePrice * Hours;
        }
    }
}
