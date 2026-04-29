using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceManager.Models
{
    // Клас з елементами даних і властивостями
    public class Car
    {
        // public модифікатор доступу
        public required string Brand { get; set; }

        public required string Model { get; set; }

        public required string PlateNumber { get; set; }

        // Вимога курсової:
        // Узагальнена колекція BindingList<Order>
        // Агрегація: автомобіль містить список замовлень
        public BindingList<Order> Orders { get; set; } = new BindingList<Order>();
    }
}