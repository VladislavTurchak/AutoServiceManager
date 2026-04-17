using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceManager.Models
{
    // Клас Order описує замовлення на ремонт або обслуговування
    public class Order
    {
        // Унікальний номер замовлення
        public int Id { get; set; }

        // Дата створення замовлення
        public DateTime Date { get; set; }

        // Послуга яка виконується (ремонт або ТО)
        // Використовується базовий клас Service (поліморфізм)
        public object? Service { get; set; }

        // Загальна ціна замовлення
        // Автоматично обчислюється через метод CalculatePrice()
        public decimal TotalPrice
        {
            get
            {
                if (Service is Service s)
                    return s.CalculatePrice();

                return 0;
            }
        }
    }
}