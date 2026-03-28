using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceManager.Models
{
    // Клас Car описує автомобіль клієнта
    public class Car
    {
        // Марка автомобіля (наприклад: Honda)
        public string Brand { get; set; }

        // Модель автомобіля (наприклад: Civic)
        public string Model { get; set; }

        // номерний знак автомобіля
        public string PlateNumber { get; set; }

        // Список замовлень (ремонтів/обслуговувань) для цього авто
        // Використовується узагальнена колекція List
        // Це приклад агрегації: автомобіль містить замовлення
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
