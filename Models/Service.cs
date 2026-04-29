/// Service.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceManager.Models
{
    // Вимога курсової:
    // Абстрактний клас
    public abstract class Service
    {
        public string Name { get; set; } = "";

        public string Type { get; set; } = "";

        public decimal BasePrice { get; set; }

        public override string ToString()
        {
            return Name;
        }

        // Абстрактний метод
        public abstract decimal CalculatePrice();
    }
}