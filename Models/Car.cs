using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AutoServiceManager.Models
{
    // Клас Car описує автомобіль клієнта
    public class Car
    {
        // Марка автомобіля (наприклад: Honda)
        public required string Brand { get; set; }

        // Модель автомобіля (наприклад: Civic)
        public required string Model { get; set; }

        // номерний знак автомобіля
        public required string PlateNumber { get; set; }

        // Список замовлень (ремонтів/обслуговувань) для цього авто
        // Використовується узагальнена колекція List
        // Це приклад агрегації: автомобіль містить замовлення
       
        public BindingList<Order> Orders { get; set; } = new BindingList<Order>();
}
}
