using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceManager.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        // Вимога курсової:
        // Використання базового класу Service (поліморфізм)
        public object? Service { get; set; }

        // Функціональний елемент класу
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