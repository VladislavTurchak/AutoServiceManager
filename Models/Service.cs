using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceManager.Models
{
    // Абстрактний базовий клас для всіх типів послуг
    // Від нього наслідуються конкретні послуги (RepairService, MaintenanceService)
    public abstract class Service
    {
        // Назва послуги
        public string Name { get; set; } = "";

        // Тип послуги (Ремонт, ТО)
        public string Type { get; set; } = "";

        // Базова ціна послуги
        public decimal BasePrice { get; set; }

        // Абстрактний метод розрахунку ціни
        // Кожен нащадок повинен реалізувати його по-своєму
        public abstract decimal CalculatePrice();
    }
}
